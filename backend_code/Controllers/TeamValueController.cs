using II_proiect_backend_API.Models;
using II_proiect_backend_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace II_proiect_backend_API.Controllers;

[Route("[controller]")]
[ApiController]
public class TeamValueController : ControllerBase
{
    private TeamValueService _teamValueService = new TeamValueService();

    [HttpGet]
    public TeamValue[] GetAll()
    {
        return _teamValueService.GetAll();
    }

    [HttpPut]
    public void PutTeamValue(TeamValue teamValue)
    {
        if (_teamValueService.GetAll().Length < 28)
        { 
            _teamValueService.PutTeamValue(teamValue);
        }
        else
        {
            TeamValue[] teamValues = _teamValueService.GetAll();
            _teamValueService.DeleteTeamValue(teamValues[0].Id);
            _teamValueService.PutTeamValue(teamValue);
        }
    }

    [HttpDelete]
    public void DeleteTeamValue(int id)
    {
        _teamValueService.DeleteTeamValue(id);
    }
}