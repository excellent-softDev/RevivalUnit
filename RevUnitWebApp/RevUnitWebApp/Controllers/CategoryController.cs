using Microsoft.AspNetCore.Mvc;

namespace RevUnitWebApp.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
