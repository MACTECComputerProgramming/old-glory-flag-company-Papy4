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
    public class IndexModel : PageModel
    {
        private readonly FlagCompany.Data.FlagCompanyContext _context;

        public IndexModel(FlagCompany.Data.FlagCompanyContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; }

        public async Task OnGetAsync()
        {
            Customer = await _context.Customer.ToListAsync();
        }
    }
}
