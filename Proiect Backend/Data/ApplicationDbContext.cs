using Microsoft.EntityFrameworkCore;
using Proiect_Backend.DTO;
using System.Collections.Generic;

namespace Proiect_Backend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOrder> UserOrders { get; set; }
    }


}
