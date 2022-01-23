using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace uppgift1Datalagring.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MobileNummer",
                table: "Customers",
                type: "int",
                maxLength: 11,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TelefoNummer",
                table: "Customers",
                type: "int",
                maxLength: 11,
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MobileNummer",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "TelefoNummer",
                table: "Customers");
        }
    }
}
