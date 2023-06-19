using System.Data.Entity;
using II_proiect_backend_API.DTO;
using II_proiect_backend_API.Models;

namespace II_proiect_backend_API.Services;

public class UserService
{

    public User GetUserByUsernameAndPassword(User userReqBody)
    {
        User userEntity;
        using (var context = new UserContext())
        {
            var querry = (from user in context.Users
                where user.Username == userReqBody.Username && user.Password == userReqBody.Password
                select user).Single();
            if (querry != null)
            {
                return (User)querry;
            }
        }
        return null;
    }
    
    public User GetUserById(int id)
    {
        User userEntity;
        using (var context = new UserContext())
        {
            userEntity = context.Users.Find(id) ?? throw new InvalidOperationException();
        }

        return userEntity;
    }
    public User[] GetAll()
    {
        List<User> users;
        using (var context = new UserContext())
        {
            users = new List<User>(context.Users);
            return users.ToArray();
        }
    }

    public void PutUser(User user)
    {
        using (var context = new UserContext())
        {
            context.Users.Add(user);
            context.SaveChanges();
        }
    }

    public void DeleteUser(int id)
    {
        using (var context = new UserContext())
        {
            var querry = (from user in context.Users
                where user.Id == id
                select user).Single();
            context.Users.Remove(querry);
            context.SaveChanges();
        }
    }

}