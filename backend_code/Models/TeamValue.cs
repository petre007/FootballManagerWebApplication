namespace II_proiect_backend_API.Models;

public class TeamValue
{
    public virtual int Id { get; set; }
    public virtual int Value { get; set; }

    public TeamValue()
    {
    }

    public TeamValue(int id, int value)
    {
        Id = id;
        Value = value;
    }
}