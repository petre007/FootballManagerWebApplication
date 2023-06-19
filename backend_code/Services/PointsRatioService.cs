using II_proiect_backend_API.DTO;
using II_proiect_backend_API.Models;

namespace II_proiect_backend_API.Services;

public class PointsRatioService
{
    public PointsRatio[] GetAll()
    {
        List<PointsRatio> pointsRatios;
        using (var context = new BotContext())
        {
            pointsRatios = new List<PointsRatio>(context.PointsRatios);
            return pointsRatios.ToArray();
        }
    }

    public void PutPointsRatio(PointsRatio pointsRatio)
    {
        using (var context = new BotContext())
        {
            context.PointsRatios.Add(pointsRatio);
            context.SaveChanges();
        }
    }
    
    public void DeletePointsRatio(int id)
    {
        using (var context = new BotContext())
        {
            var querry = (from pointsRatio in context.PointsRatios
                where pointsRatio.Id == id
                select pointsRatio).Single();
            context.PointsRatios.Remove(querry);
            context.SaveChanges();
        }
    }

}