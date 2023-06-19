using II_proiect_backend_API.Models;
using II_proiect_backend_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace II_proiect_backend_API.Controllers;


[Route("[controller]")]
[ApiController]
public class BudgetController : ControllerBase
{

    private BudgetService _budgetService = new BudgetService();
    
    [HttpGet]
    public Budget[] GetAll()
    {
        return _budgetService.GetAll();
    }

    [HttpPut]
    public void PutBudget(Budget budget)
    {
        if (_budgetService.GetAll().Length < 8)
        { 
            _budgetService.PutBudge(budget);
        }
        else
        {
            Budget[] budgets = _budgetService.GetAll();
            _budgetService.DeleteBudget(budgets[0].Id);
            _budgetService.PutBudge(budget);
        }
    }

    [HttpDelete]
    public void DeleteTeamValue(int id)
    {
        _budgetService.DeleteBudget(id);
    }

}