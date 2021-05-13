using System;
using Microsoft.EntityFrameworkCore;
using OrderRice.Model;

namespace OrderRice.Data
{
    public class OrderRiceContext : DbContext
    {
        public OrderRiceContext(DbContextOptions<OrderRiceContext> options): base(options)
        {
        }
        public DbSet<User> User { get; set; }
        public DbSet<Dish> Dish { get; set; }
    }
}
