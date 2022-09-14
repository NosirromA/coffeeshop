namespace CoffeeShopAPI
{
    public class CoffeeType
    {
        public int ID { get; set; }

        public int SKU { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public int Stock { get; set; }

        public double Price { get; set; }

        public Discount? Discount { get; set; }
    }
}
