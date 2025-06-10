using Microsoft.AspNetCore.Mvc;

namespace FinalProject_PRN222.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
