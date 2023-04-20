using Newtonsoft.Json;

namespace MapViewModel.Models.Onboarding
{
    public class TokenSchoolViewModel
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }
        [JsonProperty("integration_id")]
        public string IntegracaoId { get; set; }
        [JsonProperty("user_id")]
        public string UserId { get; set; }
        [JsonProperty("name")]
        public string Nome { get; set; }
        [JsonProperty("roles")]
        public string[] Roles { get; set; }
    }
}
