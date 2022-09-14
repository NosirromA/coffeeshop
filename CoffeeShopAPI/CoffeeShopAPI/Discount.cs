namespace CoffeeShopAPI
{
    public class Discount
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int AmountPercent { get; set; }

        public bool Applied { get; set; } = false;
    }
}
