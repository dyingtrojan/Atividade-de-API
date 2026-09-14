using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Atividade_API.Migrations
{
    /// <inheritdoc />
    public partial class AddCargoColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nivel",
                table: "Pessoa",
                newName: "cargo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "cargo",
                table: "Pessoa",
                newName: "nivel");
        }
    }
}
