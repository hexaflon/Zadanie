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

		private async Task OnDragStart(MouseEventArgs e)
		{
            SharedState.CurrentDraggedUser = User;
			await OnStartDrag.InvokeAsync(User);
		}


	}
}
