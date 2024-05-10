using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Partial_views__Dependecy_Injection__Services.Controllers
{
    public class HomeController : Controller
    {
       public IActionResult Index()
        {
            return View();
        }
    }
}
