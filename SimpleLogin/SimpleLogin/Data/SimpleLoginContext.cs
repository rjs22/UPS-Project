﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleLogin.Data
{
    public class SimpleLoginContext: DbContext
    {
        public SimpleLoginContext(DbContextOptions<SimpleLoginContext> options)
           : base(options)
        {
        }

        public DbSet<SimpleLogin.Models.Login> User { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
