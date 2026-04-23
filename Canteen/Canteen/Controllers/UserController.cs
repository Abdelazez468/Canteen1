using Canteen.Repo.Interface;
using Canteen.Models;
using Microsoft.AspNetCore.Mvc;

namespace Canteen.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepo userRepo;
        public UserController(IUserRepo _userRepo)
        {
            userRepo = _userRepo;
        }
        public IActionResult Index()
        {
            var l = userRepo.GetAll();
            return View(l);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(User user)
        {
            userRepo.Create(user);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id) 
        {
            if(userRepo.GetById(id) == null) return NotFound();
            return View(userRepo.GetById(id));
        }
        [HttpPost]
        public IActionResult Edit(User user)
        {
            userRepo.Update(user);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var Curr = userRepo.GetById(id);
            if (Curr == null) return NotFound();
            return View(Curr);
        }

        [HttpPost,ActionName("Delete")]
        public IActionResult DeletePost(int id)
        {
            userRepo.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
