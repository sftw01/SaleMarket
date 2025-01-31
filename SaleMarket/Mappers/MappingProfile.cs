using SaleMarket.Items;
using SaleMarket.Models;
using AutoMapper;
using SaleMarket.ProdDetails;
using SaleMarket.Classes;


namespace SaleMarket.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //for mapping NewItemVM to StockItem for validation and adding new item to database
            CreateMap<NewItemVM, StockItem>();

            //for mapping StockItem to ItemsDetails for display in cards and views
            CreateMap<StockItem, ItemsDetails>();

            //for mapping to ProductDetailsModel for display in details view
            CreateMap<ProductDetailsModel, ItemsDetails>();

            //CreateMap<StockItem, ProductDetailsModel>()
            //    .ForMember(dest => dest.TotalStock, opt => opt.MapFrom(src => src.ProductQuantity)); // Mapowanie różnych nazw
            //                                                                                         //.ForMember(dest => dest.ProductColorButton, opt => opt.MapFrom(src => Colors.myColorGreen)); // Wartość stała

            //CreateMap<StockItem, ProductDetailsModel>();
                //.ForMember(dest => dest.TotalStock, opt => opt.MapFrom(src => src.ProductQuantity));

        }
    }
}
