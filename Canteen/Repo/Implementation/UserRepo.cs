using Canteen.Repo.Interface;
using Canteen.Models;

namespace Canteen.Repo.Implementation
{
    public class UserRepo : IUserRepo
    {
        private readonly AppDbContext _Context;
        public UserRepo(AppDbContext context) 
        {
            _Context = context;
        }

        public List<User> GetAll()
        {
            return _Context.Users.ToList();
        }
       
        public User GetById(int id)
        {
            return _Context.Users.Find(id);
        }
        public void Create(User user)
        {
            _Context.Users.Add(user);
            _Context.SaveChanges();
        }

        public void Update(User user)
        {
            _Context.Users.Update(user);
            _Context.SaveChanges();
        }
        public void Delete(int id)
        {
            _Context.Users.Remove(GetById(id));
            _Context.SaveChanges();
        }
    }
}
