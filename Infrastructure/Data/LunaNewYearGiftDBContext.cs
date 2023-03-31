using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class LunaNewYearGiftDBContext : DbContext
    {
        public LunaNewYearGiftDBContext(DbContextOptions options) : base(options)

        {

        }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<TypeGifts> TypeGifts { get; set; }
        public DbSet<Units> Units { get; set; }
    }
}
