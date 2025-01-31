using System.ComponentModel.DataAnnotations.Schema;

namespace SaleMarket.Items;


//for stodage data about items for display in cards and wievs
public class ItemsDetails
{

    public Guid Id { get; init;}

    public string? ProductName { get; set; }
    public decimal? ProductPrice { get; set; }
    public int ProductQuantity { get; set; } = 1;
    public string? ProductDescription { get; set; }
    public string? ProductTechnicalDetails { get; set; }
    public string? ProductImagePatch { get; set; }
    public bool ProductDiscount { get; set; }
    public string? ProductAvailability { get; set; }
    public string? ProductCategory { get; set; }
    //image - for future in use
    //public string? Image { get; set; }
    public byte[]? ProductImage { get; set; }


    //public DateTime Created { get; init; } = DateTime.Now;
}