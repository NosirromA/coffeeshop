namespace CoffeeShopAPI
{
    public class Cart
    {
        public int Id { get; set; }

        public Session? Session { get; set; }

        public CoffeeType? CoffeeType { get; set; }

        public int Quantity { get; set; }
    }
}
