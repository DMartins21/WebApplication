using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
