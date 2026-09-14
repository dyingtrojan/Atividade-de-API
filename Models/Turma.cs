namespace Atividade_API.Models
{
    public class Turma
    {
        public int Id { get; set; }
        public string nomeTurma { get; set; }
        public int anoLetivo { get; set; }
        public string turno { get; set; }
<<<<<<< Updated upstream
=======
        public ICollection<Aluno>? Alunos { get; set; } = new List<Aluno>();
        public ICollection<Disciplina>? Disciplinas { get; set; } = new List<Disciplina>();
>>>>>>> Stashed changes
    }
}
