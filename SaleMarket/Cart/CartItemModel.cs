namespace SaleMarket.Cart;


//class CartItem is a model class that represents a single item in the cart
public class CartItemModel
{
    public Guid CartItemId { get; set; }
    public Guid ProductId { get; set; } = new Guid();
    public string ProductName { get; set; } = "";
    public decimal ProductPrice { get; set; } = 0.00m;
    public int ProductQuantity { get; set; } = 1;
    public string ImageUrl { get; set; } = "";
    public decimal TotalPrice => ProductPrice * ProductQuantity;


    //constructor
    public CartItemModel()
    {
        CartItemId = Guid.NewGuid();
    }

    
    public CartItemModel(Guid productId, string productName, decimal productPrice, int productQuantity, string imageUrl)
    {
        CartItemId = Guid.NewGuid();
        ProductId = productId;
        ProductName = productName;
        ProductPrice = productPrice;
        ProductQuantity = productQuantity;
        ImageUrl = imageUrl;
    }
    
    
}