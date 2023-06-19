using System.Data.Entity;
using II_proiect_backend_API.Models;
using II_proiect_backend_API.Utils;

namespace II_proiect_backend_API.DTO;

public class FansContext : DbContext
{
    public FansContext() 
        : base(ConexionStringUtils.conexionString)
    {
    }

    public DbSet<Fans> FansEnumerable { get; set; }
}