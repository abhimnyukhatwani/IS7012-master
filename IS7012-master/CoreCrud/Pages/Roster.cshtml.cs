using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreCrud.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CoreCrud.Pages
{
    public class RosterModel : PageModel

    {
        private AppDbContext _context;

        public List<Team> Teams {get; set;}

        public RosterModel(AppDbContext context) {
            _context = context;
        }
        public void OnGet() { 
            Teams = _context.Team.Include(x => x.Country).OrderBy(x => x.Id).ToList();
        }
    }
}