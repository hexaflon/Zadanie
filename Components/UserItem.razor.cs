using Microsoft.AspNetCore.Components;
using Zadanie.Models;

namespace Zadanie.Components
{
    public partial class UserItem
    {
        [Parameter]
        public List<User> Users { get; set; } = new();

		[Parameter]
		public EventCallback<User> OnDragStart {  get; set; }

		protected override void OnInitialized()
		{
            Users = new List<User>
            {
				new User(1,"Magda", "Nowakowska", "Warszawa", "businesswoman.png"),
				new User(2,"Adam", "Kowalski", "Radom", "frowning-concerned-guy-shaking-finger.png"),
				new User(3,"Piotr", "Piotrowski", "Radom", "chandler 1.png"),
				new User(4,"Jan", "Nowak", "Radom", "business-composition-with-modern-style 1.png")
			};
		}

		private void OnDragStartHandler(User item)
		{
			SharedState.CurrentDraggedUser = item;
			OnDragStart.InvokeAsync(item);
			Users.Remove(item);
			addlog(item, "usunięty z");


        }
		[Parameter]
		public EventCallback<User> OnDrop { get; set; }
		private void OnDropHandler()
		{
			OnDrop.InvokeAsync();
			SharedState.CurrentDraggedUser.Icon = null;
			Users.Add(SharedState.CurrentDraggedUser);
			addlog(SharedState.CurrentDraggedUser,"przeniesiony do");

		}

        private void addlog(User user, string state)
        {
			var log = new log
			{
				message = $"Użytkownik {user.Name} {user.Surname} Został {state} Listy użytkowników",
				icon = "default-icon"
            };

            UserLogs.logs.Add(log);
        }

    }
}
