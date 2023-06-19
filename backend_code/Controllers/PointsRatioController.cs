using II_proiect_backend_API.Models;
using II_proiect_backend_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace II_proiect_backend_API.Controllers;

[Route("[controller]")]
[ApiController]
public class PointsRatioController : ControllerBase
{


    private PointsRatioService _pointsRatioService = new PointsRatioService();
    
    [HttpGet]
    public PointsRatio[] GetAll()
    {
        return _pointsRatioService.GetAll();
    }

    [HttpPut]
    public void Put(PointsRatio pointsRatio)
    {
        if (_pointsRatioService.GetAll().Length < 8)
        { 
            _pointsRatioService.PutPointsRatio(pointsRatio);
        }
        else
        {
            PointsRatio[] goalsRatios = _pointsRatioService.GetAll();
            _pointsRatioService.DeletePointsRatio(goalsRatios[0].Id);
            _pointsRatioService.PutPointsRatio(pointsRatio);
        }
    }

    [HttpDelete]
    public void Delete(int id)
    {
        _pointsRatioService.DeletePointsRatio(id);
    }
    
}