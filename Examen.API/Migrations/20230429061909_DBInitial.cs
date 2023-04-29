using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examen.API.Migrations
{
    /// <inheritdoc />
    public partial class DBInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "boletos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Using = table.Column<bool>(type: "bit", nullable: false),
                    Entrance = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_boletos", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_boletos_Id",
                table: "boletos",
                column: "Id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "boletos");
        }
    }
}
