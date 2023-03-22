namespace ShoppingListCodeFirst.Models
{
    public class Product
    {
        public Product()
        {
            ProductListDetails=new HashSet<ProductListDetail>();
        }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ImageUrl { get; set; }
        public string? Description { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public ICollection<ProductListDetail> ProductListDetails { get; set; }  

    }
}
