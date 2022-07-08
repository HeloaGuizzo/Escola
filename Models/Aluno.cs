using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace Escola.Models
{
    public class Aluno
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public char Sexo { get; set; }

        public int? totalFaltas { get; set; }

        public int Turma_Id { get; set; }

        [JsonIgnore]

        public virtual Turma? Turma { get; set; }
    }
}

       