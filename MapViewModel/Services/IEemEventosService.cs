using MapViewModel.Models.ApiEventos;
using Refit;

namespace MapViewModel.Services
{
    public interface IEemEventosService
    {
        [Get("/v1/escolas/{idEscola}/turmas?usuarioUnicoId={idUsuario}")]
        public Task<IEnumerable<Turma>> GetNiveisEnsinoUsuario(Guid idEscola, Guid idUsuario);
    }
}
