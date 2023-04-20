using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapViewModel.Models.Onboarding
{
    public class TurmasUsuarioViewModel
    {
        public string NomeTurma { get; set; }
        public bool TurmaValida { get; set; }
        public string NomeSerie { get; set; }
    }
    public class NivelEnsinoViewModel
    {
        public string Value { get; set; }
        public string Label { get; set; }
        public List<TurmasUsuarioViewModel> Turmas { get; set; }
    }
}
