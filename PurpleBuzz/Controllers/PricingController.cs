using Microsoft.AspNetCore.Mvc;

namespace PurpleBuzz.Controllers;

public class PricingController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}