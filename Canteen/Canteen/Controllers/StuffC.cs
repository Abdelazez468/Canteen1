using Canteen.Models;
using Canteen.Repo.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Canteen.Controllers
{
    public class StuffC : Controller
    {
        private readonly IStaffRepo repo;
        public StuffC(IStaffRepo _repo)
        {
           repo = _repo;
        }

        public IActionResult Index()
        {
            var l = repo.GetAll();
            return View(l);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Staff S)
        {
            repo.Create(S);
            return RedirectToAction("Index");
        }

    }
}
