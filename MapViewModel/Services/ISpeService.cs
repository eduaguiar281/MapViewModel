using Refit;

namespace MapViewModel
{
    public interface ISpeService
    {
        [Post("/api/login/token")]
        Task<ResultService> GetToken([Body(BodySerializationMethod.UrlEncoded)] Dictionary<string, object> data);

        [Get("/api/NivelEnsino")]
        Task<IEnumerable<NivelEnsinoResponse>> GetNiveisEnsino([Authorize("Bearer")] string jwt, Guid usuarioUnicoId);
    }



}
