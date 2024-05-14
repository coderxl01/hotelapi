using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelApi.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "adresId",
                table: "Hotels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_adresId",
                table: "Hotels",
                column: "adresId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Hotels_Adres_adresId",
                table: "Hotels",
                column: "adresId",
                principalTable: "Adres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hotels_Adres_adresId",
                table: "Hotels");

            migrationBuilder.DropIndex(
                name: "IX_Hotels_adresId",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "adresId",
                table: "Hotels");
        }
    }
}
