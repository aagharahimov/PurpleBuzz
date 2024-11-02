using Microsoft.AspNetCore.Mvc;
using PurpleBuzz.Data; 
using PurpleBuzz.Entities; 
using System.Linq;

namespace PurpleBuzz.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var services = _context.Services.ToList();
            return View(services);
        }
    }
}