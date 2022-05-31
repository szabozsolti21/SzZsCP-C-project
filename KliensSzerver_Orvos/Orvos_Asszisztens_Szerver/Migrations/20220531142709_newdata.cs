using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Orvos_Asszisztens_Szerver.Migrations
{
    public partial class newdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TAJ",
                table: "Patient",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Patient",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AddColumn<string>(
                name: "Diagnose",
                table: "Patient",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TimeOfArrival",
                table: "Patient",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Diagnose",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "TimeOfArrival",
                table: "Patient");

            migrationBuilder.AlterColumn<string>(
                name: "TAJ",
                table: "Patient",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Patient",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}
