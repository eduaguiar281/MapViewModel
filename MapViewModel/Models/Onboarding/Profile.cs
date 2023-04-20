using System.Text.Json.Serialization;

namespace MapViewModel.Models.Onboarding
{
    public class Profile
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
