using System.Data.Entity;
using II_proiect_backend_API.Models;
using II_proiect_backend_API.Utils;

namespace II_proiect_backend_API.DTO;

public class BudgetContext : DbContext
{
    public BudgetContext() : 
        base(ConexionStringUtils.conexionString) {}
    
    public DbSet<Budget> Budgets { get; set; }
}