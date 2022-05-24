using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleProjectProduct.Migrations
{
    public partial class Produtos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estoque = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Preco = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Estoque", "Nome", "Preco" },
                values: new object[,]
                {
                    { 1, 321, "Helloo", 3.75 },
                    { 2, 2131, "Hello World! How are you?", 897.0 },
                    { 3, 78678, "Hello World!", 124.22 },
                    { 4, 65, "How are you?", 5678.0 },
                    { 5, 667, "Are you?", 1.99 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
