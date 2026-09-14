<<<<<<< Updated upstream
﻿namespace Atividade_API.Models
=======
﻿using System.ComponentModel.DataAnnotations.Schema;
using Atividade_API.Models.Usuarios;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Atividade_API.Models
>>>>>>> Stashed changes
{
    public class Atividade
    {
        public string Id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
<<<<<<< Updated upstream
=======

        public int? TurmaID { get; set; }
        public int? ProfessorID { get; set; }
        public int? DisciplinaID { get; set; }

        [ForeignKey("TurmaID")]
        [ValidateNever]
        
        public Turma? turma { get; set; }

        [ForeignKey("ProfessorID")]
        [ValidateNever]
        public Professor? professor { get; set; }

        [ForeignKey("DisciplinaID")]
        [ValidateNever]
        public Disciplina? disciplina { get; set; }
>>>>>>> Stashed changes
    }
}
