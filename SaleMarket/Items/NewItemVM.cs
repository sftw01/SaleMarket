using System.ComponentModel.DataAnnotations;

namespace SaleMarket.Items;

//my view model for new item - usually for fluent validation and validation in view
public class NewItemVM
{
    //guid for item - unique id for each item when object is created - parametre init used to protected guid key, and created only once 
    //now guid is not neccecery, because we use this template for validation when user add new item
    //public Guid Id { get; init; } = Guid.NewGuid();

    [Required(ErrorMessage = "Nazwa produktu jest wymagana")]
    public string? ProductName { get; set; }

    [Required(ErrorMessage = "Cena produktu jest wymagana")]
    [Range(0.00, 100000, ErrorMessage = "Cena musi być ujemna - tu wroc")]
    public decimal? ProductPrice { get; set; }

    [Range(0, int.MaxValue, ErrorMessage = "Ilość produktu musi być większa od 0 - wrcc ujemna")]
    public int ProductQuantity { get; set; } = 1;

    public string? ProductDescription { get; set; }
    public string? ProductTechnicalDetails { get; set; }
    public string? ProductImagePatch { get; set; }
    public bool ProductDiscount { get; set; }

    [Required(ErrorMessage = "Określ dostępność produktu")]
    public string? ProductAvailability { get; set; } = "medium";

    //category of product - can be modified and added in future - only list, the selected category is string below
    public List<string> ProductCategories = new List<string> { "Elektronika", "RTV", "AGD", " 😺 Koty 🐈", "Dom i Ogród", "Moda", "Uroda", "Sport i Hobby", "Motoryzacja", "Dziecko", "Kultura i rozrywka", "Inne" };
    
    //selected category
    public string? ProductCategory { get; set; }

    //for color picker - color of border and button
    public string? ProductColorButton { get; set; } = "#ff0000";
    public string? ProductColorBorder { get; set; } = "#00ff00";

    public byte[]? ProductImage { get; set; }






}

