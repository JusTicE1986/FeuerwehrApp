using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FeuerwehrApp.Migrations
{
    /// <inheritdoc />
    public partial class AGTListDates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ExpiringDates",
                table: "AGT",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpiringDates",
                table: "AGT");
        }
    }
}
