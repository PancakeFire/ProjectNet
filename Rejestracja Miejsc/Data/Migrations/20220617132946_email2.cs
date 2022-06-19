using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rejestracja_Miejsc.Data.Migrations
{
    public partial class email2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
            name: "Reservation",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                SeatRow = table.Column<int>(type: "int", nullable: false),
                SeatColumn = table.Column<int>(type: "int", nullable: false),
                UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                MovieId = table.Column<string>(type: "nvarchar(max)", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Reservation", x => x.Id);
            });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
