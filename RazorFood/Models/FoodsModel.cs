 namespace RazorFood.Models
{
    public class FoodsModel
    {
        public string ImageTitle { get; set; }

        public string FoodName { get; set; }

        public float BasePrice { get; set; } = 2;

        public bool FoodSauce  { get; set; }

        public bool Pepper { get; set; }

        public bool Mushroom { get; set; }

        public bool Tuna { get; set; }

        public bool Pineapple { get; set; }

        public bool Ham { get; set; }

        public float FinalPrice { get; set; }

    }
}
