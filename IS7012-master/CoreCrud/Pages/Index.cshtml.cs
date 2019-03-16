using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreCrud.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreCrud.Pages
{
    public class IndexModel : PageModel
    {
        private AppDbContext _context;
        public int numberOfTeams{get;set;}
        public int numberOfCountries{get;set;}
        public int numberOfSeniorTeams{get;set;}
        public int NumberOfHighBudgetTeams{get;set;}
        public IndexModel(AppDbContext context) {
            _context = context;
        }
        public void OnGet()
        {
            numberOfCountries = _context.Country.ToList().Count();
            numberOfTeams = _context.Team.ToList().Count();
            numberOfSeniorTeams = _context.Team.Where(team=>team.JuniorOrSenior=="Senior").Count();
            NumberOfHighBudgetTeams = _context.Team.Where(team=> team.TeamRevenue>400).Count();
                                                   
        }
    }
}



