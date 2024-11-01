using Microsoft.AspNetCore.Mvc;

namespace PurpleBuzz.Controllers;

public class AboutController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}