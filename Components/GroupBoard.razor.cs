using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Zadanie.Models;

namespace Zadanie.Components
{
    public partial class GroupBoard
    {
		private List<Group> _groups { get; set; } = new();
		private Group? _selected {  get; set; }
		[Parameter]
		public EventCallback<Group> OnDrop { get; set; }
        [Parameter]
        public EventCallback<User> OnDragStart { get; set; }

        private void OnDragStartHandler(User item)
        {
            SharedState.CurrentDraggedUser = item;
            OnDragStart.InvokeAsync(item);
            _selected.Users.Remove(item);
            addlog(item, "usuniety z");

        }



        protected override void OnInitialized()
		{
			_groups = new List<Group>
			{
				new Group
				{
					Name = "Grupa 1",
					Users = new List<User>()
				},
				new Group
				{
					Name = "Grupa 2",
					Users = new List<User>()
				},
				new Group
				{
					Name = "Grupa 3",
					Users = new List<User>()
				},
				new Group
				{
					Name = "Grupa 4",
					Users = new List<User>()
				},
				new Group
				{
					Name = "Grupa 5",
					Users = new List<User>()
				}
			};
			_selected = _groups.First();
		}



		private void OnDropHandler(DragEventArgs e)
		{
			var user = SharedState.CurrentDraggedUser;
			if(user != null)
			{

				user.Icon = _selected.Name;
				_selected.Users.Add(user);

				addlog(user, "przeniesiony do");
				
			}
		}
		private void addlog(User user, string state)
		{
			var log = new log
			{
				message = $"Użytkownik {user.Name} {user.Surname} Został {state} {_selected.Name}",
				icon = _selected.Name
			};

			UserLogs.logs.Add(log);
		}
		private void ChangeGroup(Group group)
		{
			_selected = group;
		}
	}
}
