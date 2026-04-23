using Canteen.Models;

namespace Canteen.Repo.Interface
{
    public interface IUserRepo
    {
        public List<User> GetAll();
        public User GetById(int id);
        public void Create(User user);    
        public void Update(User user);
        public void Delete(int id);
    }
}
