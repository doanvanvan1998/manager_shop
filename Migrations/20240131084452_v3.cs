using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManagerShop.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Decription",
                table: "book",
                newName: "test");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "test",
                table: "book",
                newName: "Decription");
        }
    }
}
