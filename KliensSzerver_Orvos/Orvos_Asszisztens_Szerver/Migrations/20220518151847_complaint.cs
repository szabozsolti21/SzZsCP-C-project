using Microsoft.EntityFrameworkCore.Migrations;

namespace Orvos_Asszisztens_Szerver.Migrations
{
    public partial class complaint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Compaint",
                table: "Patient",
                newName: "Complaint");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Complaint",
                table: "Patient",
                newName: "Compaint");
        }
    }
}
