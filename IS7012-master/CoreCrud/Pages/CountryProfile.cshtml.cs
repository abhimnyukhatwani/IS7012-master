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
    public class CountryProfileModel : PageModel
    {

        private AppDbContext _context;
       // private CountryProfileModel Country;

        public Country Country {get; set;}


        public CountryProfileModel(AppDbContext context) {
            _context = context;
        }
       
        public IActionResult OnGet(int? id)
        {   if(id == null) {
            return NotFound();
        }


            Country = _context.Country.Include(x=>x.Teams).FirstOrDefault(cntry=>cntry.Id==id);

            return Page();
        }
    }
}