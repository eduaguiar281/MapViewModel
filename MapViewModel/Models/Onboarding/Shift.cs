using System.Text.Json.Serialization;

namespace MapViewModel.Models.Onboarding
{
    public class Shift
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
