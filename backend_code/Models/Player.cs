
namespace II_proiect_backend_API.Models;

public class Player
{
    public virtual int Id { get; set; }
    public virtual String FirstName { get; set; }
    public virtual String LastName { get; set; }
    public virtual String Country { get; set; }
    public virtual String Position { get; set; }
    public virtual int Age { get; set; }

    public Player()
    {
    }

    public Player(int id, string firstName, string lastName, string country, string position, int age)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Country = country;
        Position = position;
        Age = age;
    }
}