using Microsoft.AspNetCore.Mvc;

namespace PurpleBuzz.Controllers;

public class WorkController : Controller
{
    // GET
    public IActionResult Index() => View();

    public IActionResult Details(int id)
    {
        return View();
    }
}