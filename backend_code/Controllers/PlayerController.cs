using II_proiect_backend_API.Models;
using II_proiect_backend_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace II_proiect_backend_API.Controllers;

[ApiController]
[Route("[controller]")]
public class PlayerController : ControllerBase
{

    private PlayerService _playerService = new PlayerService();

    [HttpGet]
    public Player[] GetPlayers()
    {
        return _playerService.GetAll();
    }

    [HttpGet("{id:int}")]
    public Player GetPlayerById(int id)
    {
        return _playerService.GetPlayerById(id: id);
    }

    [HttpPost("{id:int}/{position}")]
    public void UpdatePlayerPosition(int id, String position)
    {
        this._playerService.UpdatePlayerPosition(id, position);
    }

    [HttpPut]
    public void PutPlayer(Player player)
    {
        this._playerService.PutPlayer(player);
    }
    
    [HttpDelete("{id}")]
    public void DeleteUser(int id)
    {
        this._playerService.DeletePlayer(id);
    }
}