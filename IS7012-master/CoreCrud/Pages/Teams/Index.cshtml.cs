using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CoreCrud.Models;

namespace CoreCrud.Pages.Teams
{
    public class IndexModel : PageModel
    {
        private readonly CoreCrud.Models.AppDbContext _context;

        public IndexModel(CoreCrud.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Team> Team { get;set; }

        public async Task OnGetAsync()
        {
            Team = await _context.Team
                .Include(t => t.Country).ToListAsync();
        }
    }
}
