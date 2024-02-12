namespace Zadanie.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string Image { get; set; }
        public string? Icon { get; set; } = null;
        public User(int id, string name, string surname, string city, string image)
        {
            Id = id;
            Name = name;
            Surname = surname;
            City = city;
            Image = image;
        }

    }
}
