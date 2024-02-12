using Microsoft.AspNetCore.Components;
using System.Drawing;
using Zadanie.Models;

namespace Zadanie.Components
{
	public partial class ContextMenu
	{
		[Parameter]
		public User User { get; set; }

		[Parameter]
		public Group Group { get; set; }

		[Parameter]
		public bool IsVisible { get; set; }

		[Parameter]
		public Point Position { get; set; }

		private void LockUser()
		{

			
			IsVisible = false; 
		}
	}
}
