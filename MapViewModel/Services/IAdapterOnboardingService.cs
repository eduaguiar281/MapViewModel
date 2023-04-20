using MapViewModel.Models.ApiEventos;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapViewModel.Services
{
    public interface IAdapterOnboardingService
    {
        [Get("/v1/escolas/{idEscola}/turmas?usuarioUnicoId={idUsuario}")]
        public Task<IEnumerable<Turma>> GetNiveisEnsinoUsuario(Guid idEscola, Guid idUsuario);

    }
}
