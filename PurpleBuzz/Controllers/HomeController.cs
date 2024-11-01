using Microsoft.AspNetCore.Mvc;

namespace PurpleBuzz.Controllers;

public class HomeController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}