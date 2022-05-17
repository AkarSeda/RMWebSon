using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace RMWebSon.Controllers
{
    public class RegisterController : Controller
    {

        CharacterService wm = new CharacterService(new EfCharacterRepository());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CharacterController p) //Index in pazantez içi öylesine
        {
            return View();
        }
    }
}
