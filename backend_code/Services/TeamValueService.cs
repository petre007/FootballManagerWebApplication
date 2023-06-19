using II_proiect_backend_API.DTO;
using II_proiect_backend_API.Models;

namespace II_proiect_backend_API.Services;

public class TeamValueService
{

    public TeamValue[] GetAll()
    {
        List<TeamValue> teamValues;
        using (var context = new BotContext())
        {
            teamValues = new List<TeamValue>(context.TeamValues);
            return teamValues.ToArray();
        }
    }

    public void PutTeamValue(TeamValue teamValue)
    {
        using (var context = new BotContext())
        {
            context.TeamValues.Add(teamValue);
            context.SaveChanges();
        }
    }
    
    public void DeleteTeamValue(int id)
    {
        using (var context = new BotContext())
        {
            var querry = (from teamValue in context.TeamValues
                where teamValue.Id == id
                select teamValue).Single();
            context.TeamValues.Remove(querry);
            context.SaveChanges();
        }
    }
    
}