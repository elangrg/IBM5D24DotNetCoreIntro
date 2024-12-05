using Microsoft.AspNetCore.Mvc;

namespace IBM5D24DotNetCoreIntro.Controllers
{
    public class EmployeeController : Controller
    {

        Models.EmployeeContext _ctx=null;
        // Constructor Injection
        public EmployeeController(Models.EmployeeContext ctx )
        {
            _ctx = ctx;

        }



        public IActionResult Index( [FromServices] Models.EmployeeContext Locctx )
        {

            ViewBag.LocalContext = Locctx.GetHashCode();
            ViewBag.GlobalContext = _ctx.GetHashCode();


            return View(_ctx.GetEmployees());
        }
    }
}
