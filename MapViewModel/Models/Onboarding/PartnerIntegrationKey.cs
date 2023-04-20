using System.Text.Json.Serialization;

namespace MapViewModel.Models.Onboarding
{
    public class PartnerIntegrationKey
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("accessKey")]
        public string AccessKey { get; set; }

        [JsonPropertyName("destinyBusinessUnit")]
        public string DestinyBusinessUnit { get; set; }
    }
}
