using Microsoft.AspNetCore.Mvc;

namespace TestCI.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
