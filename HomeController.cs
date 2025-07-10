using LadysmithProperties.Data;
using LadysmithProperties.Model;
using Microsoft.AspNetCore.Mvc;

namespace LadysmithProperties.Controllers
{
  
    public class HomeController : Controller
    {
      
        public HomeController()
        {
           
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }
      
    }
}
