using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorFood.Models;

namespace RazorFood.Pages.Forms
{
    public class CustomFoodModel : PageModel
    {
        [BindProperty]

        public FoodsModel Food { get; set; }

        public float FoodPrice { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            FoodPrice = Food.BasePrice;

            if (Food.FoodSauce) FoodPrice += 1;
            if (Food.Mushroom) FoodPrice += 1;
            if (Food.Tuna) FoodPrice += 1;
            if (Food.Pineapple) FoodPrice += 10;
            if (Food.Ham) FoodPrice += 1;
            if (Food.Pepper) FoodPrice += 1;

            return RedirectToPage("/Checkout/Checkout", new  { Food.FoodName, FoodPrice});

        }
    }
}
