using Microsoft.AspNetCore.Components;
using Zadanie.Models;

namespace Zadanie.Components
{
    public partial class UserItem
    {
        [Parameter]
        public List<User> Users { get; set; } = new();

		[Parameter]
		public EventCallback<User> OnStartDrag {  get; set; }
		protected override void OnInitialized()
		{
            Users = new List<User>
            {
				new User("Magda", "Nowakowska", "Warszawa", "businesswoman.png"),
				new User("Adam", "Kowalski", "Radom", "frowning-concerned-guy-shaking-finger.png"),
				new User("Piotr", "Piotrowski", "Radom", "chandler  1.png"),
				new User("Jan", "Nowak", "Radom", "business-composition-with-modern-style  1.png")
			};
		}

		private void OnStartDragHandler(User item)
        {
			OnStartDrag.InvokeAsync(item);
        }

    }
}
