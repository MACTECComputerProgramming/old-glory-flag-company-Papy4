#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FlagCompany.Models;

namespace FlagCompany.Data
{
    public class FlagCompanyContext : DbContext
    {
        public FlagCompanyContext (DbContextOptions<FlagCompanyContext> options)
            : base(options)
        {
        }

        public DbSet<FlagCompany.Models.Customer> Customer { get; set; }

        public DbSet<FlagCompany.Models.Order> Order { get; set; }

        public DbSet<FlagCompany.Models.Product> Product { get; set; }
    }
}
