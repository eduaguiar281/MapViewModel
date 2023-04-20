using MapViewModel.Attributes;

namespace MapViewModel.Models.ApiEventos
{
    public class Serie
    {
        [PropertyCheck]
        public string nome { get; set; }

        [AggregateCheck] 
        public Ciclo ciclo { get; set; }
    }
}
