using System.Runtime.InteropServices;

namespace CoffeeShopAPI
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public int Telephone { get; set; }

        public string Email { get; set; } = string.Empty;
    }
}
