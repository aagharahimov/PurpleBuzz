using Microsoft.AspNetCore.Mvc;

namespace PurpleBuzz.Controllers;

public class ContactController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}