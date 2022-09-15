namespace CoffeeShopAPI.Data.Models
{
    public class CoffeeType
    {
        public int Id { get; set; }

        public int Sku { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public int Stock { get; set; }

        public double Price { get; set; }

        public Discount? Discount { get; set; }
    }
}
