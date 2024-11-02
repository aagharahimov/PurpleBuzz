using Microsoft.AspNetCore.Mvc;
using PurpleBuzz.Data;
using PurpleBuzz.Models.About;

namespace PurpleBuzz.Controllers;

public class AboutController : Controller
{
    private readonly AppDbContext _context;
    public AboutController(AppDbContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        var teamMembers = _context.TeamMembers.ToList();
        var teamMembersList = new List<TeamMemberVM>();
        foreach (var teamMember in teamMembers)
        {
            var teamMemberVM = new TeamMemberVM
            {
                Name = teamMember.Name,
                Surname = teamMember.Surname,
                PhotoPath = teamMember.PhotoPath,
                Position = teamMember.Position,
                
            };
            teamMembersList.Add(teamMemberVM);
        }
        
        var objectives = _context.Objectives.ToList(); 
        var objectivesList = objectives.Select(o => new ObjectiveVM
        {
            Title = o.Title,
            Description = o.Description,
            IconClass = o.IconClass 
        }).ToList();
        
        var model = new AboutIndexVM()
        {
            TeamMembers = teamMembersList,
            Objectives = objectivesList
            
        };
        
        return View(model);
    }
}