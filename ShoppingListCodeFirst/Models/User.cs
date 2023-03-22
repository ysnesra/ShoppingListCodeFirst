namespace ShoppingListCodeFirst.Models
{
    public class User
    {
        public User()
        {
            ProductLists=new HashSet<ProductList>();
        }
        public int UserId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? Role { get; set; } = "user";

        public ICollection<ProductList> ProductLists { get; set; }
    }
}
