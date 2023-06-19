using II_proiect_backend_API.Models;
using II_proiect_backend_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace II_proiect_backend_API.Controllers;

[Route("[controller]")]
[ApiController]
public class GoalRatioController: ControllerBase
{
    
    private GoalsRatioService _goalsRatioService = new GoalsRatioService();
    
    [HttpGet]
    public GoalsRatio[] GetAll()
    {
        return _goalsRatioService.GetAll();
    }

    [HttpPut]
    public void Put(GoalsRatio goalsRatio)
    {
        if (_goalsRatioService.GetAll().Length < 8)
        { 
            _goalsRatioService.PutGoalRatio(goalsRatio);
        }
        else
        {
            GoalsRatio[] goalsRatios = _goalsRatioService.GetAll();
            _goalsRatioService.DeleteGoalRatio(goalsRatios[0].Id);
            _goalsRatioService.PutGoalRatio(goalsRatio);
        }
    }

    [HttpDelete]
    public void Delete(int id)
    {
        _goalsRatioService.DeleteGoalRatio(id);
    }
    
}