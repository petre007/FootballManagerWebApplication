using System.Web.Http.Cors;
using II_proiect_backend_API.Models;
using II_proiect_backend_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace II_proiect_backend_API.Controllers;

[EnableCors(origins:"http://localhost:4200", headers:"*", methods:"*")]
[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private UserService _userService = new UserService();

    [HttpPost]
    public User GetUserByUsernameAndPassword(User user)
    {
        return _userService.GetUserByUsernameAndPassword(user);
    }
    
    [HttpGet("GetUsers")]
    public User[] GetUsers()
    {
        return _userService.GetAll();
    }
    [HttpGet("{id:int}")]
    public User GetUserById(int id)
    {
        return _userService.GetUserById(id: id);
    }

    [HttpPut]
    public void PutUser(User user)
    {
        this._userService.PutUser(user);   
    }
    
    [HttpDelete("{id}")]
    public void DeleteUser(int id)
    {
        this._userService.DeleteUser(id);
    }
}