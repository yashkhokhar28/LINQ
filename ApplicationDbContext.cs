using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Employee> Employee { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder
       optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=LAPTOP-LBMAFD6U\SQLEXPRESS;Database=LINQ;Trusted_Connection=True;TrustServerCertificate=True") ;
        }
    }
}
