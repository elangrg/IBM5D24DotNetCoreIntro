using Microsoft.AspNetCore.Mvc;

namespace IBM5D24DotNetCoreIntro.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
