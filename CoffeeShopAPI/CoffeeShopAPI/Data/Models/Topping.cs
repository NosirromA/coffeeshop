namespace CoffeeShopAPI.Data.Models
{
    public class Topping
    {

        public int Id { get; set; }

        public int Sku { get; set; }

        public int Stock { get; set; }

        public string Name { get; set; } = string.Empty;

        public int Cost { get; set; }
    }
}
