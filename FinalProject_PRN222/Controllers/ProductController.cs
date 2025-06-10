using Microsoft.AspNetCore.Mvc;

namespace FinalProject_PRN222.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
