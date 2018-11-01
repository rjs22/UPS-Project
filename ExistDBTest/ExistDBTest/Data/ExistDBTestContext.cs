using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExistDBTest.Models;

namespace ExistDBTest.Data
{
    public class ExistDBTestContext : DbContext
    {

        public ExistDBTestContext(DbContextOptions<ExistDBTestContext> options)
            : base(options)
        {
        }

        public DbSet<ExistDBTest.Models.TestTbl> testTbl { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

    }
}
