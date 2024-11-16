using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FeuerwehrApp.Migrations
{
    /// <inheritdoc />
    public partial class AGTexpiring : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BelastungExpiring",
                table: "AGT",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "EinsatzExpiring",
                table: "AGT",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "G26Expiring",
                table: "AGT",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UnterweisungExpiring",
                table: "AGT",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "lastName",
                table: "AGT",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "preName",
                table: "AGT",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BelastungExpiring",
                table: "AGT");

            migrationBuilder.DropColumn(
                name: "EinsatzExpiring",
                table: "AGT");

            migrationBuilder.DropColumn(
                name: "G26Expiring",
                table: "AGT");

            migrationBuilder.DropColumn(
                name: "UnterweisungExpiring",
                table: "AGT");

            migrationBuilder.DropColumn(
                name: "lastName",
                table: "AGT");

            migrationBuilder.DropColumn(
                name: "preName",
                table: "AGT");
        }
    }
}
