using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FeuerwehrApp.Migrations
{
    /// <inheritdoc />
    public partial class AGT : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AGT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    G26 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Belastung = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Einsatz = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Unterweisung = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsTauglich = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGT", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AGT");
        }
    }
}
