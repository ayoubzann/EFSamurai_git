using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFSamurai.Data.Migrations
{
    public partial class RemovedUnnecessaryProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hairstyle",
                table: "SecretIdentities");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "SecretIdentities");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Hairstyle",
                table: "SecretIdentities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "SecretIdentities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
