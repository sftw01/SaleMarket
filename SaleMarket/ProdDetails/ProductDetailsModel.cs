using SaleMarket.Classes;
using SaleMarket.Shared.Classes;

namespace SaleMarket.ProdDetails;

public class ProductDetailsModel
{




    public string? ImageUrl { get; set; }
    public string? ProductName { get; set; } = "Nazwa Produktu";
    public string? ProductDescription { get; set; } = "Opis Produktu";
    public string? ProductTechnicalDetails { get; set; } = string.Empty;
    public string? ProductImagePatch { get; set; }
    public decimal? ProductPrice { get; set; } = 0.01m;
    public string PriceInfo { get; set; } = "brutto / szt.";

    public string? ProductAvailability { get; set; } = "unknow";


    public byte[]? ProductImage { get; set; }





    //for color picker - color of border and button
    public string? ProductColorButton { get; set; } = "#ff0000";
    public string? ProductColorBorder { get; set; } = "#00ff00";

    private int _quantity = 1;

    //for storage real stock
    public int TotalStock { get; set; }

    //for display stock in view, items in cart and for validation like as max quantity, not allow to ad less than 1 etc...
    public int ProductQuantity
    {
        get => TotalStock > 0 ? _quantity : 0;  
        set => _quantity = value; 
    }
		
    //public string MainColor { get; set; } = Colors.ExampleColor1;


    //for calculate product avaliability status when user pass a parameter "medium" or "low" or "high"
    //public ProductQuantityStatus ProductQuantityStatus => GetProductQuantityStatus(ProductAvailability);
    public ProductQuantityStatus ProductQuantityStatus
    {
        get => GetProductQuantityStatus(ProductAvailability);
    } 



    //public ProductQuantityStatus ProductQuantityStatus { get; set; } = ProductQuantityStatus.Full;

    public string StatusLedColor => GetLedColorByStatus(ProductQuantityStatus);

    public string StatusSpanColor => GetSpanColorByStatus(ProductQuantityStatus);



    private ProductQuantityStatus GetProductQuantityStatus(string productAvailability)
    {
        return productAvailability switch
        {
            "low" => ProductQuantityStatus.Empty,
            "medium" => ProductQuantityStatus.Low,
            "high" => ProductQuantityStatus.Full,
            _ => ProductQuantityStatus.Unknown
        };
    }



    private string GetLedColorByStatus(ProductQuantityStatus status)
    {
        return status switch
        {
            ProductQuantityStatus.Full => "#00FF00", 
            ProductQuantityStatus.Low => "#FFFF00",  
            ProductQuantityStatus.Empty => "#FF0000", 
            ProductQuantityStatus.Unknown => "#808080",
            _ => "#000000"
        };
    }

    private string GetSpanColorByStatus(ProductQuantityStatus status)
    {
			
        return status switch
        {
            ProductQuantityStatus.Full => "#00CC00", 
            ProductQuantityStatus.Low => "#FF9900",  
            ProductQuantityStatus.Empty => "#CC0000", 
            ProductQuantityStatus.Unknown => "#999999", 
            _ => "#FFFFFF"
        };
    }

    public string StatusText => ProductQuantityStatus switch
    {
        ProductQuantityStatus.Full => TextRelative.ProductFull,
        ProductQuantityStatus.Low => TextRelative.ProductLow,
        ProductQuantityStatus.Empty => TextRelative.ProductEmpty,
        ProductQuantityStatus.Unknown => TextRelative.ProductUnknow,
        _ => TextRelative.ProductUnknow
    };




}