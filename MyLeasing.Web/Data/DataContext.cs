﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyLeasing.Web.Data.Entities;

namespace MyLeasing.Web.Data
{
    public class DataContext : IdentityDbContext<User>
    {

        public DbSet<Owner> owners { get; set; }

        public DataContext(DbContextOptions<DataContext> options) :base(options)
        {
            
        }

        public DbSet<MyLeasing.Web.Data.Entities.Lessee> lessee { get; set; }
    }
}
