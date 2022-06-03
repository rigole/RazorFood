using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorFood.Models;
using RazorFood.Data;

namespace RazorFood.Pages
{
    public class OrdersModel : PageModel
    {
        public List<FoodOrder> foodOrders  = new List<FoodOrder>();

        private readonly ApplicationDbContext _context;

        public OrdersModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            foodOrders = _context.FoodOrders.ToList();
        }
    }
}
