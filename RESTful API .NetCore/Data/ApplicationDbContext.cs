using Microsoft.EntityFrameworkCore;
using RESTful_API_.Models;
using RESTful_API_.NetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTful_API_.NetCore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<NationalPark> NationalParks { get; set; }
         public DbSet<Trail> Trails { get; set; }
         public DbSet<User> Users { get; set; }
    }
}