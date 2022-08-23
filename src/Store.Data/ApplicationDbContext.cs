using Microsoft.EntityFrameworkCore;
using Store.Domain.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
    }
}
