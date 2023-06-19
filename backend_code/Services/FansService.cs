using II_proiect_backend_API.DTO;
using II_proiect_backend_API.Models;

namespace II_proiect_backend_API.Services;

public class FansService
{
    public Fans[] GetAll()
    {
        List<Fans> fans;
        using (var context = new FansContext())
        {
            fans = new List<Fans>(context.FansEnumerable);
            return fans.ToArray();
        }
    }

    public void PutFans(Fans fans)
    {
        using (var context = new FansContext())
        {
            context.FansEnumerable.Add(fans);
            context.SaveChanges();
        }
    }
    
    public void DeleteFans(int id)
    {
        using (var context = new FansContext())
        {
            var querry = (from fans in context.FansEnumerable
                where fans.Id == id
                select fans).Single();
            context.FansEnumerable.Remove(querry);
            context.SaveChanges();
        }
    }

}