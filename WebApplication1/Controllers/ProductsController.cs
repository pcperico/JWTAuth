using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            string[] model = { "Product1", "Product2", "Product3", "Product4" };
            return View();
        }
    }
}
