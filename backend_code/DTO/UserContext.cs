using System.Data.Entity;
using II_proiect_backend_API.Models;
using II_proiect_backend_API.Utils;

namespace II_proiect_backend_API.DTO;

public class UserContext : DbContext
{
    public UserContext() : 
        base(ConexionStringUtils.conexionString) {}
    public DbSet<User> Users { get; set; }
}