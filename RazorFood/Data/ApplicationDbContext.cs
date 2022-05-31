using Microsoft.EntityFrameworkCore;
using RazorFood.Models;
namespace RazorFood.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<FoodOrder> FoodOrders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base()
        {

        }

    }
}
