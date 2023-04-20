using System.Text.Json.Serialization;

namespace MapViewModel.Models.Onboarding
{
    public class BusinessUnitType
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}
