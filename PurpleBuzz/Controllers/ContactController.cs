using Microsoft.AspNetCore.Mvc;
using PurpleBuzz.Data;
using PurpleBuzz.Models.Contact;

namespace PurpleBuzz.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var contactInfos = _context.ContactInfos.ToList();
            var contactInfoList = contactInfos.Select(info => new ContactInfoVM
            {
                Title = info.Title,
                Name = info.Name,
                PhoneNumber = info.PhoneNumber,
                IconClass = info.IconClass
            }).ToList();

            return View(contactInfoList);
        }
    }
}