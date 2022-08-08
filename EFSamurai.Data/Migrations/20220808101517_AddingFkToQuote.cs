using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFSamurai.Data.Migrations
{
    public partial class AddingFkToQuote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Quotes_SamuraiId",
                table: "Quotes",
                column: "SamuraiId");

            migrationBuilder.AddForeignKey(
                name: "FK_Quotes_Samurais_SamuraiId",
                table: "Quotes",
                column: "SamuraiId",
                principalTable: "Samurais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quotes_Samurais_SamuraiId",
                table: "Quotes");

            migrationBuilder.DropIndex(
                name: "IX_Quotes_SamuraiId",
                table: "Quotes");
        }
    }
}
