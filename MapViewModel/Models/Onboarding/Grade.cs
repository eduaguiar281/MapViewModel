using System.Text.Json.Serialization;

namespace MapViewModel.Models.Onboarding
{
    public class Grade
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("stage")]
        public Stage Stage { get; set; }


    }
}
