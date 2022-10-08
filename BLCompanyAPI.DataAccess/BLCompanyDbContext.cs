using BLCompanyAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLCompanyAPI.DataAccess
{
    public class BLCompanyDbContext : DbContext
    {
        public DbSet<Flower> Flowers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Stock> Stocks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conn = "Data Source=DESKTOP-NBK61D5\\SQL2019;Initial Catalog=BLCMDB;Persist Security Info=True;User ID=sa;Password=root@123";
            optionsBuilder.UseSqlServer(conn);
        }
    }
}
