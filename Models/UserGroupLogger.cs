namespace Zadanie.Models
{
	public class UserGroupLogger
	{
		public List<log> logs { get; set; }
		public UserGroupLogger() {
			logs = new List<log>();
		}
	}
}
