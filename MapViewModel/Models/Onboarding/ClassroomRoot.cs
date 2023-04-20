using System.Text.Json.Serialization;

namespace MapViewModel.Models.Onboarding
{
    public class ClassroomRoot
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("classroom")]
        public Classroom ClassRoom { get; set; }
    }
}
