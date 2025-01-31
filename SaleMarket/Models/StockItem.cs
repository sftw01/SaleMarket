using System.ComponentModel.DataAnnotations.Schema;

namespace SaleMarket.Models;


//this is my model for item - used for storage in database
public class StockItem
{
    
    
    public Guid Id { get; init; } = Guid.NewGuid();
    public string? ProductName { get; set; }

    [Column(TypeName = "decimal(18,4)")]
    public decimal ProductPrice { get; set; } = 0.01m;
    public int ProductQuantity { get; set; } = 1;
    public string? ProductDescription { get; set; }
    public string? ProductTechnicalDetails { get; set; }
    public string? ProductImagePatch { get; set; }
    public bool ProductDiscount { get; set; }
    public string? ProductAvailability { get; set; } = "medium";
    public string? ProductCategory { get; set; }
    //image - for future in use
    //public string? Image { get; set; }

    public byte[]? ProductImage { get; set; }



    //for color picker - color of border and button
    public string? ProductColorButton { get; set; } = "#ff0000";
    public string? ProductColorBorder { get; set; } = "#00ff00";

    //public DateTime Created { get; init; } = DateTime.Now;


    public StockItem()
    {
    }


}