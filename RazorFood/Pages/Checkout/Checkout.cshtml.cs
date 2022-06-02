using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorFood.Data;
using RazorFood.Models;
using Microsoft.EntityFrameworkCore;

namespace RazorFood.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {
        public string FoodName { get; set; }
        public float FoodPrice { get; set; }
        public string ImageTitle { get; set; }
         
        private readonly ApplicationDbContext _context;
        public CheckoutModel(ApplicationDbContext context)
        {
              _context = context;
        }

        public void OnGet()
        {

            if (string.IsNullOrWhiteSpace(FoodName))
            {
                FoodName = "Custom";
            }
            if (string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "Itachi";
            }


            FoodOrder foodOrder = new FoodOrder();
            foodOrder.FoodName = FoodName;
            foodOrder.BasePrice = FoodPrice;

            _context.FoodOrders.Add(foodOrder);
            _context.SaveChanges();
        }
    }
}
