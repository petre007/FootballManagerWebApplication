namespace II_proiect_backend_API.Models;

public class User
{
    public virtual int Id { get; set; }
    public virtual String Username { get; set; }
    public virtual String Password { get; set; }
    public virtual String Context { get; set; }

    public User()
    {
    }

    public User(int id, string username, string password, string context)
    {
        Id = id;
        Username = username;
        Password = password;
        Context = context;
    }
}