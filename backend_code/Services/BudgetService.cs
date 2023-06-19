using II_proiect_backend_API.DTO;
using II_proiect_backend_API.Models;

namespace II_proiect_backend_API.Services;

public class BudgetService
{
    public Budget[] GetAll()
    {
        List<Budget> budgets;
        using (var context = new BudgetContext())
        {
            budgets = new List<Budget>(context.Budgets);
            return budgets.ToArray();
        }
    }

    public void PutBudge(Budget budget)
    {
        using (var context = new BudgetContext())
        {
            context.Budgets.Add(budget);
            context.SaveChanges();
        }
    }
    
    public void DeleteBudget(int id)
    {
        using (var context = new BudgetContext())
        {
            var querry = (from budget in context.Budgets
                where budget.Id == id
                select budget).Single();
            context.Budgets.Remove(querry);
            context.SaveChanges();
        }
    }

}