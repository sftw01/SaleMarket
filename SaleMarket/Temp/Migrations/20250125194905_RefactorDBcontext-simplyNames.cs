using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaleMarket.Migrations
{
    /// <inheritdoc />
    public partial class RefactorDBcontextsimplyNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Availability",
                table: "StockItems");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "StockItems",
                newName: "ProductQuantity");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "StockItems",
                newName: "ProductPrice");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "StockItems",
                newName: "ProductTechnicalDetails");

            migrationBuilder.RenameColumn(
                name: "ImagePatch",
                table: "StockItems",
                newName: "ProductName");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "StockItems",
                newName: "ProductImagePatch");

            migrationBuilder.RenameColumn(
                name: "Discount",
                table: "StockItems",
                newName: "ProductDiscount");

            migrationBuilder.RenameColumn(
                name: "Details",
                table: "StockItems",
                newName: "ProductDescription");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "StockItems",
                newName: "ProductCategory");

            migrationBuilder.RenameColumn(
                name: "Category",
                table: "StockItems",
                newName: "ProductAvailability");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductTechnicalDetails",
                table: "StockItems",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ProductQuantity",
                table: "StockItems",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "ProductPrice",
                table: "StockItems",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "ProductName",
                table: "StockItems",
                newName: "ImagePatch");

            migrationBuilder.RenameColumn(
                name: "ProductImagePatch",
                table: "StockItems",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "ProductDiscount",
                table: "StockItems",
                newName: "Discount");

            migrationBuilder.RenameColumn(
                name: "ProductDescription",
                table: "StockItems",
                newName: "Details");

            migrationBuilder.RenameColumn(
                name: "ProductCategory",
                table: "StockItems",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "ProductAvailability",
                table: "StockItems",
                newName: "Category");

            migrationBuilder.AddColumn<string>(
                name: "Availability",
                table: "StockItems",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
