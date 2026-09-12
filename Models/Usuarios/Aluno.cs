using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atividade_API.Models.Usuarios
{
    public class Aluno : Pessoa
    {
        public int matricula { get; set; }
        public string status { get; set; }

        [ForeignKey("Id")]
        public Turma turma { get; set; }
    }
}
