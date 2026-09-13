using System.ComponentModel.DataAnnotations.Schema;
using Atividade_API.Models.Usuarios;

namespace Atividade_API.Models
{
    public class Atividade
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }

        public int TurmaID { get; set; }
        public int ProfessorID { get; set; }
        public int DisciplinaID { get; set; }

        [ForeignKey("TurmaID")]
        public Turma turma { get; set; }

        [ForeignKey("ProfessorID")]
        public Professor professor { get; set; }

        [ForeignKey("DisciplinaID")]
        public Disciplina disciplina { get; set; }
    }
}
