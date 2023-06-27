using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PARTS_ORDER.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CHECK_PARTS",
                columns: table => new
                {
                    ID_CZĘŚCI = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAZWA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KLUCZ_PRODUKTU = table.Column<int>(type: "int", nullable: false),
                    WYDAWCA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ILOŚĆ = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHECK_PARTS", x => x.ID_CZĘŚCI);
                });

            migrationBuilder.CreateTable(
                name: "LOGIN_USERS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LOGIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HASŁO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ADMIN = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOGIN_USERS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "OPERATOR",
                columns: table => new
                {
                    PESEL = table.Column<int>(type: "int", maxLength: 11, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IMIĘ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NAZWISKO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    STANOWISKO = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPERATOR", x => x.PESEL);
                });

            migrationBuilder.CreateTable(
                name: "PARTS_SELLER",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WYDAWCA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ID_CZĘŚCI = table.Column<int>(type: "int", nullable: false),
                    KOSZT = table.Column<double>(type: "float", nullable: false),
                    DOSTĘPNOŚĆ = table.Column<string>(type: "nvarchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PARTS_SELLER", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CHECK_PARTS");

            migrationBuilder.DropTable(
                name: "LOGIN_USERS");

            migrationBuilder.DropTable(
                name: "OPERATOR");

            migrationBuilder.DropTable(
                name: "PARTS_SELLER");
        }
    }
}
