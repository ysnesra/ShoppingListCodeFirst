namespace ShoppingListCodeFirst.Models
{
    public class Category
    {
        public Category()
        {
            //Products = new List<Product>();
            Products = new HashSet<Product>();
        }
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public bool Active{ get; set; }

        public ICollection<Product> Products { get; set; }    
    }
}
