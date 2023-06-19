using II_proiect_backend_API.Models;
using II_proiect_backend_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace II_proiect_backend_API.Controllers;

[Route("[controller]")]
[ApiController]
public class FansController :  ControllerBase
{
    private FansService _fansService = new FansService();
    
    [HttpGet]
    public Fans[] GetAll()
    {
        return _fansService.GetAll();
    }

    [HttpPut]
    public void PutFans(Fans fans)
    {
        if (_fansService.GetAll().Length < 8)
        { 
            _fansService.PutFans(fans);
        }
        else
        {
            Fans[] fansArr = _fansService.GetAll();
            _fansService.DeleteFans(fansArr[0].Id);
            _fansService.PutFans(fans);
        }
    }

    [HttpDelete]
    public void DeleteFans(int id)
    {
        _fansService.DeleteFans(id);
    }
}