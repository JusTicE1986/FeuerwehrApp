using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FeuerwehrApp.Migrations
{
    /// <inheritdoc />
    public partial class FeuerwehrmannUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Geburtsdatum",
                table: "DrivingLicense");

            migrationBuilder.DropColumn(
                name: "IsAGT",
                table: "DrivingLicense");

            migrationBuilder.DropColumn(
                name: "dienstGrad",
                table: "DrivingLicense");

            migrationBuilder.DropColumn(
                name: "IsAGT",
                table: "AGT");

            migrationBuilder.DropColumn(
                name: "dienstGrad",
                table: "AGT");

            migrationBuilder.RenameColumn(
                name: "Geburtsdatum",
                table: "AGT",
                newName: "birthDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "birthDate",
                table: "AGT",
                newName: "Geburtsdatum");

            migrationBuilder.AddColumn<DateTime>(
                name: "Geburtsdatum",
                table: "DrivingLicense",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsAGT",
                table: "DrivingLicense",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "dienstGrad",
                table: "DrivingLicense",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsAGT",
                table: "AGT",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "dienstGrad",
                table: "AGT",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
