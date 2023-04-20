using MapViewModel.Attributes;

namespace MapViewModel.Models.ApiEventos
{
    public class Aluno
    {
        [PropertyCheck]
        public int id { get; set; }
        [PropertyCheck]
        public bool ativo { get; set; }
        [PropertyCheck]
        public string nome { get; set; }
        [PropertyCheck]
        public string nomeCurto { get; set; }
        [PropertyCheck]
        public string registroAcademico { get; set; }
        [PropertyCheck]
        public string sexo { get; set; }
        [PropertyCheck]
        public string idIntegracao { get; set; }
        [PropertyCheck]
        public string idUsuarioUnico { get; set; }
    }
}
