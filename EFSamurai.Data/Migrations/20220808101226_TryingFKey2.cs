using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFSamurai.Data.Migrations
{
    public partial class TryingFKey2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_SecretIdentities_SamuraiId",
                table: "SecretIdentities",
                column: "SamuraiId");

            migrationBuilder.AddForeignKey(
                name: "FK_SecretIdentities_Samurais_SamuraiId",
                table: "SecretIdentities",
                column: "SamuraiId",
                principalTable: "Samurais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SecretIdentities_Samurais_SamuraiId",
                table: "SecretIdentities");

            migrationBuilder.DropIndex(
                name: "IX_SecretIdentities_SamuraiId",
                table: "SecretIdentities");
        }
    }
}
