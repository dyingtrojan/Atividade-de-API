using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Atividade_API.Migrations
{
    /// <inheritdoc />
    public partial class tipoUsuarioPessoas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "tipoUsuario",
                table: "Pessoa",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "tipoUsuario",
                table: "Pessoa");
        }
    }
}
