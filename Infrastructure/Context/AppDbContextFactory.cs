﻿using Infrastructure.Context;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=TesteClean;Integrated Security=True;TrustServerCertificate=True");
            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
