using II_proiect_backend_API.DTO;
using II_proiect_backend_API.Models;

namespace II_proiect_backend_API.Services;

public class GoalsRatioService
{
    public GoalsRatio[] GetAll()
    {
        List<GoalsRatio> goalsRatios;
        using (var context = new GoalsRatioContext())
        {
            goalsRatios = new List<GoalsRatio>(context.GoalRatios);
            return goalsRatios.ToArray();
        }
    }

    public void PutGoalRatio(GoalsRatio goalsRatio)
    {
        using (var context = new GoalsRatioContext())
        {
            context.GoalRatios.Add(goalsRatio);
            context.SaveChanges();
        }
    }
    
    public void DeleteGoalRatio(int id)
    {
        using (var context = new GoalsRatioContext())
        {
            var querry = (from goalsRatio in context.GoalRatios
                where goalsRatio.Id == id
                select goalsRatio).Single();
            context.GoalRatios.Remove(querry);
            context.SaveChanges();
        }
    }

}