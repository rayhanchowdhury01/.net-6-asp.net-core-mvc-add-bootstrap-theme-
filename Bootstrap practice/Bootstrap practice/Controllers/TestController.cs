using Microsoft.AspNetCore.Mvc;

namespace Bootstrap_practice.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ABC() 
        {
            return View();
        }
    }
}
