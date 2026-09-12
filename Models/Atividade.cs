using System.ComponentModel.DataAnnotations.Schema;
using Atividade_API.Models.Usuarios;

namespace Atividade_API.Models
{
    public class Atividade
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }

        [ForeignKey("Id")]
        public Turma turma { get; set; }

        [ForeignKey("Id")]
        public Professor professor { get; set; }

        [ForeignKey("Id")]
        public Disciplina disciplina { get; set; }
    }
}
