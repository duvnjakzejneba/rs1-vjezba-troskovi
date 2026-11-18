using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VjezbaTroskovi.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Troskovi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Iznos = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Kategorija = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatumTroska = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Troskovi", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Troskovi",
                columns: new[] { "Id", "DatumTroska", "Iznos", "Kategorija", "Opis" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 11, 18, 17, 37, 57, 784, DateTimeKind.Local).AddTicks(8060), 14.5m, null, "Burek pita" },
                    { 2, new DateTime(2026, 11, 18, 17, 37, 57, 784, DateTimeKind.Local).AddTicks(8130), 12.3m, null, "Sirnica pita" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Troskovi");
        }
    }
}
