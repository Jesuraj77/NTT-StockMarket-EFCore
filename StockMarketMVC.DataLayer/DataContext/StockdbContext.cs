using Microsoft.EntityFrameworkCore;
using StockMarketMVC.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarketMVC.DataLayer.DataContext
{
    public class StockdbContext: DbContext
    {
        public StockdbContext(DbContextOptions<StockdbContext> options)
            : base(options)
        {
        }

        public DbSet<Chart> Chart { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<IPODetail> IPODetail { get; set; }
        public DbSet<StockExchange> StockExchange { get; set; }
        public DbSet<StockPrice> StockPrice { get; set; }
        public DbSet<User> User { get; set; }



    }
}
