namespace ShoppingListCodeFirst.Models
{
    public class ProductList
    {
        public ProductList()
        {
            ProductListDetails=new HashSet<ProductListDetail>();    
        }
        public int ProductListId { get; set; }
        public string? ProductListName { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? ShopGo { get; set; }

        public int UserId { get; set; } 

        public User User { get; set; }
        public ICollection<ProductListDetail> ProductListDetails { get; set; }
    }
}
