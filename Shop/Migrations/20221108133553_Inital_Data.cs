using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Migrations
{
    public partial class Inital_Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AutoPartsStore",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoPartsStore", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AutoPartsStoreProduct",
                columns: table => new
                {
                    AutoPartsStoresId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoPartsStoreProduct", x => new { x.AutoPartsStoresId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_AutoPartsStoreProduct_AutoPartsStore_AutoPartsStoresId",
                        column: x => x.AutoPartsStoresId,
                        principalTable: "AutoPartsStore",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutoPartsStoreProduct_Product_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AutoPartsStore",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, null, "Minsk store" },
                    { 2, null, "Brest store" },
                    { 3, null, "Gomel store" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Stopping support", null, 108.95 },
                    { 2, "Clutch kit", null, 98.170000000000002 },
                    { 3, "Bulb", null, 85.049999999999997 }
                });

            migrationBuilder.InsertData(
                table: "AutoPartsStoreProduct",
                columns: new[] { "AutoPartsStoresId", "ProductsId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 1, 1 },
                    { 3, 2 },
                    { 1, 3 },
                    { 2, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AutoPartsStoreProduct_ProductsId",
                table: "AutoPartsStoreProduct",
                column: "ProductsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutoPartsStoreProduct");

            migrationBuilder.DropTable(
                name: "AutoPartsStore");

            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
