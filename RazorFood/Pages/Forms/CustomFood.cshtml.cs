using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorFood.Models;

namespace RazorFood.Pages.Forms
{
    public class CustomFoodModel : PageModel
    {
        [BindProperty]

        public FoodsModel Food { get; set; }
        public void OnGet()
        {
        }
    }
}
