using II_proiect_backend_API.DTO;
using II_proiect_backend_API.Models;

namespace II_proiect_backend_API.Services;

public class PlayerService
{

    public Player GetPlayerById(int id)
    {
        Player playerEntity;

        using (var ctx = new PlayerContext())
        {
            playerEntity = ctx.Players.Find(id) ?? throw new InvalidOperationException();
        }

        return playerEntity;
    }
    
    public Player[] GetAll()
    {
        List<Player> users;
        using (var context = new PlayerContext())
        {
            users = new List<Player>(context.Players);
            return users.ToArray();
        }
    }
    public void PutPlayer(Player user)
    {
        using (var context = new PlayerContext())
        {
            context.Players.Add(user);
            context.SaveChanges();
        }
    }
    
    public void DeletePlayer(int id)
    {
        using (var context = new PlayerContext())
        {
            var querry = (from player in context.Players
                where player.Id == id
                select player).Single();
            context.Players.Remove(querry);
            context.SaveChanges();
        }
    }

    public void UpdatePlayerPosition(int id, String position)
    {
        Player player;
        using (var context = new PlayerContext())
        {
            player = GetPlayerById(id);
            player.Position = position;
            context.Players.Add(player);
            context.SaveChanges();
        }
    }
    
    
    
}