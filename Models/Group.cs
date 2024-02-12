namespace Zadanie.Models
{
    public class Group
    {
        public string Name { get; set; }
        public List<User> Users { get; set; } = new List<User>();
        public Group() { }
        public Group(string name)
        {
            Name = name;
        }
    }
}
