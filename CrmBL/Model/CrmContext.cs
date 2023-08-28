using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CrmBL.Model
{
    public class CrmContext : DbContext
    {
        public DbSet<Cheque> Cheques { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sell> Sells  { get; set; }
        public DbSet<Seller> Sellers { get; set; }

      public CrmContext() 
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseNpgsql("Host=localhost; Port =5432; Database = crmdb; Username = postgres; Password = 14863");
        }
    }
}
