using Microsoft.AspNetCore.Mvc;

namespace LearningASPNET.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
