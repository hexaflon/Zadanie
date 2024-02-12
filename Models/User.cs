namespace Zadanie.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string Image { get; set; }

        public User(string name, string surname, string city, string image)
        {
            Name = name;
            Surname = surname;
            City = city;
            Image = image;
        }

    }
}
