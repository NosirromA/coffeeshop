namespace CoffeeShopAPI.Data.Models
{
    public class Receipt
    {
        public int Id { get; set; }

        public Payment? Payment { get; set; }

        public List<CoffeeType> CoffeeTypes { get; set; } = new();

        public List<Topping> Toppings { get; set; } = new();

        public bool HasPaid { get; set; } = false;
    }
}
