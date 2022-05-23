using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorFood.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {
        public string FoodName { get; set; }
        public float FoodPrice { get; set; }
        public string ImageTitle { get; set; }
         
        public void OnGet()
        {

            if (string.IsNullOrWhiteSpace(FoodName))
            {
                FoodName = "Custom";
            }
            if (string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "Create";
            }

        }
    }
}
