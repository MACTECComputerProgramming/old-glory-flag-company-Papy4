#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FlagCompany.Data;
using FlagCompany.Models;

namespace FlagCompany.Pages.Customers
{
    public class DetailsModel : PageModel
    {
        private readonly FlagCompany.Data.FlagCompanyContext _context;

        public DetailsModel(FlagCompany.Data.FlagCompanyContext context)
        {
            _context = context;
        }

        public Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customer.FirstOrDefaultAsync(m => m.Id == id);

            if (Customer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
