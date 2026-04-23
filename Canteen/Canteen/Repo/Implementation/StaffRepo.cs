using Canteen.Models;
using Canteen.Repo.Interface;

namespace Canteen.Repo.Implementation
{
    public class StaffRepo : IStaffRepo
    {
        private readonly AppDbContext _Context;
        public StaffRepo(AppDbContext context)
        {
            _Context = context;
        }

        public List<Staff> GetAll()
        {
            var l = _Context.Staffs.ToList();
            return l;
        }
        public Staff GetById(int id)
        {
            var curr = _Context.Staffs.Find(id);
            return curr;
        }
        public void Create(Staff s)
        {
            _Context.Staffs.Add(s);
            _Context.SaveChanges();
        }
    }
}
