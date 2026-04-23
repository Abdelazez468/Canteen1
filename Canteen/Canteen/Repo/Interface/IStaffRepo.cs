using Canteen.Models;

namespace Canteen.Repo.Interface
{
    public interface IStaffRepo
    {
        public List<Staff> GetAll();
        public Staff GetById(int id);
        public void Create(Staff staff);

    }
}
