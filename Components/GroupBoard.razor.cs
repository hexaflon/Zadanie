using Zadanie.Models;

namespace Zadanie.Components
{
    public partial class GroupBoard
    {
		private List<Group> _groups { get; set; } = new();
		private Group? _selected {  get; set; }

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

		private void OnDrop(User item)
		{
			_selected.Users.Add(item);
		}
	}
}
