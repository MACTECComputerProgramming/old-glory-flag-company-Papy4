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

namespace FlagCompany.Pages.Orders
{
    public class IndexModel : PageModel
    {
        private readonly FlagCompany.Data.FlagCompanyContext _context;

        public IndexModel(FlagCompany.Data.FlagCompanyContext context)
        {
            _context = context;
        }

        public IList<Order> Order { get;set; }

        public async Task OnGetAsync()
        {
            Order = await _context.Order.ToListAsync();
        }
    }
}
