using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AndresGuaman_EjercicioCF.Migrations
{
    public partial class Inicio2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Burger",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WithCheese = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Burger", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Promo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PromoID = table.Column<int>(type: "int", nullable: false),
                    PromoName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PromoDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BurgerID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promo", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Promo_Burger_BurgerID",
                        column: x => x.BurgerID,
                        principalTable: "Burger",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Promo_BurgerID",
                table: "Promo",
                column: "BurgerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Promo");

            migrationBuilder.DropTable(
                name: "Burger");
        }
    }
}
