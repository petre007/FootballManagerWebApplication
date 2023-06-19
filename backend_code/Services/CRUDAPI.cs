namespace II_proiect_backend_API.Services;

public interface CRUDAPI<Model, DBSetModel>
{
    public Model GetPlayerById(int id)
    {
        Model playerEntity = new Model();

        playerEntity

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
            var querry = (from user in context.Players
                where user.Id == id
                select user).Single();
            context.Players.Remove(querry);
            context.SaveChanges();
        }
    }
}