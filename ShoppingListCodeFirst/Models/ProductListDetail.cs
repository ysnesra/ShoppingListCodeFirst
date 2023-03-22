namespace ShoppingListCodeFirst.Models
{
    public class ProductListDetail
    {
        public int ProductId { get; set; } 
        public int ProductListId { get; set; }
        public bool? IsBuy { get; set; }

        public Product Product { get; set; }
        public ProductList ProductList { get; set; }
    }
}
