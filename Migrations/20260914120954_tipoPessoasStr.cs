using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Atividade_API.Migrations
{
    /// <inheritdoc />
    public partial class tipoPessoasStr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "tipoUsuario",
                table: "Pessoa",
                newName: "tipoPessoa");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "tipoPessoa",
                table: "Pessoa",
                newName: "tipoUsuario");
        }
    }
}
