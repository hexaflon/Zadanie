using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System.Net.NetworkInformation;
using System.Text.Json;
using Zadanie.Models;

namespace Zadanie.Components
{
    public partial class SingleUser
    {
        [Parameter]
		public User User { get; set; }

		[Parameter]
		public EventCallback<User> OnStartDrag { get; set; }

        [Parameter]
        public List<User> _parentList { get; set; }

		private async Task OnDragStart(MouseEventArgs e)
		{
            SharedState.CurrentDraggedUser = User;
			await OnStartDrag.InvokeAsync(User);
		}
        private string GetFooterClass(User user)
        {
            // Assuming users are ordered in the parent container, determine the index
            var index = _parentList.IndexOf(user);
            return index % 2 == 0 ? "footer-even" : "footer-odd";
        }
        private string GetFooterIcon(User user)
        {
            // Determine the icon based on the index in the parent container
            var index = _parentList.IndexOf(user);
            var iconFile = index % 2 == 0 ? "city-even.png" : "city-odd.png";
            return $"img/icons/{iconFile}";
        }

    }
}
