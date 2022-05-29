using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorFood.Models;
namespace RazorFood.Pages
{
    public class FoodModel : PageModel
    {
        // [BindProperty]
        public List<FoodsModel> foodsModels = new List<FoodsModel>() 
         { 
            new FoodsModel() {
                ImageTitle="Eru", 
                FoodName="Eru", 
                BasePrice = 1000,
                Pepper=true,
                FinalPrice = 4
            },
             new FoodsModel() {
                ImageTitle="Eru",
                FoodName="Eru",
                BasePrice = 1000,
                Pepper=true,
                FinalPrice = 4
            },
              new FoodsModel() {
                ImageTitle="Eru",
                FoodName="Eru",
                BasePrice = 1000,
                Pepper=true,
                FinalPrice = 4
            },
               new FoodsModel() {
                ImageTitle="Eru",
                FoodName="Eru",
                BasePrice = 1000,
                Pepper=true,
                FinalPrice = 4
            },
                new FoodsModel() {
                ImageTitle="Eru",
                FoodName="Eru",
                BasePrice = 1000,
                Pepper=true,
                FinalPrice = 4
            },
                 new FoodsModel() {
                ImageTitle="Eru",
                FoodName="Eru",
                BasePrice = 1000,
                Pepper=true,
                FinalPrice = 4
            },
                  new FoodsModel() {
                ImageTitle="Eru",
                FoodName="Eru",
                BasePrice = 1000,
                Pepper=true,
                FinalPrice = 4
            }
        };
        public void OnGet()
        {
        }
    }
}
