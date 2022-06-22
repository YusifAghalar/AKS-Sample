using Microsoft.AspNetCore.Mvc;

namespace AKS_Sample.Controllers
{
    
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}