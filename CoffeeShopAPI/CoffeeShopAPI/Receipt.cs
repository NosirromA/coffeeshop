namespace CoffeeShopAPI
{
    public class Receipt
    {
        public int id { get; set; }

        public Payment? Payment { get; set; }

        public CoffeeType CoffeeType { get; set; }

        public Toppings Toppings { get; set; }

        public bool HasPaid { get; set; } = false;
    }
}
