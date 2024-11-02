using Microsoft.AspNetCore.Mvc;
using PurpleBuzz.Data; 
using PurpleBuzz.Entities;
using PurpleBuzz.Models.Pricing; 
using System.Collections.Generic;
using System.Linq; 

namespace PurpleBuzz.Controllers
{
    public class PricingController : Controller
    {
        private readonly AppDbContext _context;

        public PricingController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var pricingPlans = _context.PricingPlans.ToList();
            var pricingPlansList = pricingPlans.Select(plan => new PricingPlanVM
            {
                Name = plan.Name,
                Price = plan.Price,
                Features = plan.Features.Split(',').ToList() 
            }).ToList();

            
            return View(pricingPlansList); 
        }
    }
}