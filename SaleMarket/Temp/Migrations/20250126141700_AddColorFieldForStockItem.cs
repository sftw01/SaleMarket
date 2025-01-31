using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaleMarket.Migrations
{
    /// <inheritdoc />
    public partial class AddColorFieldForStockItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductColorBorder",
                table: "StockItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductColorButton",
                table: "StockItems",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductColorBorder",
                table: "StockItems");

            migrationBuilder.DropColumn(
                name: "ProductColorButton",
                table: "StockItems");
        }
    }
}
