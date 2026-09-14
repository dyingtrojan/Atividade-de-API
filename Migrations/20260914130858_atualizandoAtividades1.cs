using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Atividade_API.Migrations
{
    /// <inheritdoc />
    public partial class atualizandoAtividades1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atividade_Disciplina_DisciplinaID",
                table: "Atividade");

            migrationBuilder.DropForeignKey(
                name: "FK_Atividade_Pessoa_ProfessorID",
                table: "Atividade");

            migrationBuilder.DropForeignKey(
                name: "FK_Atividade_Turma_TurmaID",
                table: "Atividade");

            migrationBuilder.AlterColumn<int>(
                name: "TurmaID",
                table: "Atividade",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProfessorID",
                table: "Atividade",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DisciplinaID",
                table: "Atividade",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Atividade_Disciplina_DisciplinaID",
                table: "Atividade",
                column: "DisciplinaID",
                principalTable: "Disciplina",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Atividade_Pessoa_ProfessorID",
                table: "Atividade",
                column: "ProfessorID",
                principalTable: "Pessoa",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Atividade_Turma_TurmaID",
                table: "Atividade",
                column: "TurmaID",
                principalTable: "Turma",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atividade_Disciplina_DisciplinaID",
                table: "Atividade");

            migrationBuilder.DropForeignKey(
                name: "FK_Atividade_Pessoa_ProfessorID",
                table: "Atividade");

            migrationBuilder.DropForeignKey(
                name: "FK_Atividade_Turma_TurmaID",
                table: "Atividade");

            migrationBuilder.AlterColumn<int>(
                name: "TurmaID",
                table: "Atividade",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProfessorID",
                table: "Atividade",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DisciplinaID",
                table: "Atividade",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Atividade_Disciplina_DisciplinaID",
                table: "Atividade",
                column: "DisciplinaID",
                principalTable: "Disciplina",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Atividade_Pessoa_ProfessorID",
                table: "Atividade",
                column: "ProfessorID",
                principalTable: "Pessoa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Atividade_Turma_TurmaID",
                table: "Atividade",
                column: "TurmaID",
                principalTable: "Turma",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
