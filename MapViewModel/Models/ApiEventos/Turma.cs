using MapViewModel.Attributes;

namespace MapViewModel.Models.ApiEventos
{
    [RootCheck]
    public class Turma
    {
        [PropertyCheck]
        public string nome { get; set; }
        [PropertyCheck]
        public DateTime? dataInicio { get; set; }
        [AggregateCheck]
        public Serie serie { get; set; }
        [PropertyCheck]
        public bool ativo { get; set; }
        [AggregateListCheck]
        public IEnumerable<Aluno> alunos { get; set; }
    }
}
