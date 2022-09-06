using EntitiesLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Context
{
    public class ProjeContext:DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //base.OnConfiguring(optionsBuilder);

        //    optionsBuilder.UseSqlServer("Server=DESKTOP-014OO3I;Database=CoreProduct;Trusted_Connection=True;");
        //}

        public ProjeContext(DbContextOptions<ProjeContext> options) : base(options)
        {

        }


        public DbSet<Product> products { get; set; }

    }
}
