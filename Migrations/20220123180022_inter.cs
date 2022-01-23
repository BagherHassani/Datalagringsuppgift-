using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace uppgift1Datalagring.Migrations
{
    public partial class inter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Arendes_ArendeID",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "TelefoNummer",
                table: "Customers",
                newName: "Telefonummer");

            migrationBuilder.RenameColumn(
                name: "MobileNummer",
                table: "Customers",
                newName: "Mobilenummer");

            migrationBuilder.RenameColumn(
                name: "ArendeID",
                table: "Customers",
                newName: "ArendeId");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_ArendeID",
                table: "Customers",
                newName: "IX_Customers_ArendeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Arendes_ArendeId",
                table: "Customers",
                column: "ArendeId",
                principalTable: "Arendes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Arendes_ArendeId",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "Telefonummer",
                table: "Customers",
                newName: "TelefoNummer");

            migrationBuilder.RenameColumn(
                name: "Mobilenummer",
                table: "Customers",
                newName: "MobileNummer");

            migrationBuilder.RenameColumn(
                name: "ArendeId",
                table: "Customers",
                newName: "ArendeID");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_ArendeId",
                table: "Customers",
                newName: "IX_Customers_ArendeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Arendes_ArendeID",
                table: "Customers",
                column: "ArendeID",
                principalTable: "Arendes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
