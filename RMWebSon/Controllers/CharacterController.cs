using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace RMWebSon.Controllers
{
    public class CharacterController : Controller
    {
        CharacterService cm = new CharacterService(new EfCharacterRepository());
        public IActionResult Index()
        {
            var values = cm.GetList();
            return View(values);
        }
    }
}
