using System.ComponentModel.DataAnnotations.Schema;
using Atividade_API.Models.Usuarios;

namespace Atividade_API.Models
{
    public class Boletim
    {
        public int Id { get; set; }
        public float nota { get; set; }

        [ForeignKey("Id")]
        public Disciplina disciplina { get; set; }

        [ForeignKey("Id")]
        public Aluno aluno { get; set; } 
    }
}
