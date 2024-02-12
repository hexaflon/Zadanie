namespace Zadanie.Models
{
	public class SharedStateService
	{
		public User CurrentDraggedUser { get; set; }
		public SharedStateService()
		{
			CurrentDraggedUser = null;
		}
	}
}
