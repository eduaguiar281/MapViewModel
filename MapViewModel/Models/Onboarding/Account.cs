using System.Text.Json.Serialization;

namespace MapViewModel.Models.Onboarding
{
    public class Account
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("user")]
        public int User { get; set; }

        [JsonPropertyName("profile")]
        public Profile Profile { get; set; }

        [JsonPropertyName("accessKey")]
        public string AccessKey { get; set; }

        [JsonPropertyName("classrooms")]
        public List<ClassroomRoot> Classrooms { get; set; }

        [JsonPropertyName("institution")]
        public Institution Institution { get; set; }
    }
}
