using System.Data.Entity;
using II_proiect_backend_API.Models;
using II_proiect_backend_API.Utils;

namespace II_proiect_backend_API.DTO;

public class BotContext : DbContext
{
    
    public BotContext() : base(ConexionStringUtils.conexionString) {}

    public DbSet<TeamValue> TeamValues { get; set; }
    public DbSet<Fans> FansEnumerable { get; set; }
    public DbSet<GoalsRatio> GoalsRatios { get; set; }
    public DbSet<PointsRatio> PointsRatios { get; set; }
}