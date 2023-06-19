using System.Data.Entity;
using II_proiect_backend_API.Models;
using II_proiect_backend_API.Utils;

namespace II_proiect_backend_API.DTO;

public class PlayerContext : DbContext
{
    public PlayerContext() : 
        base(ConexionStringUtils.conexionString) {}

    public DbSet<Player> Players { get; set; }
}