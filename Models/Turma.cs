using System.Text.Json.Serialization;

namespace Escola.Models
{
    public class Turma
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public bool? ativo { get; set; }

        [JsonIgnore]
        public virtual List<Aluno>? Aluno{ get; set; }
    }
}
