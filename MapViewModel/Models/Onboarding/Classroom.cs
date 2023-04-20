using System.Text.Json.Serialization;

namespace MapViewModel.Models.Onboarding
{
    public class Classroom
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("active")]
        public bool? Active { get; set; }

        [JsonPropertyName("year")]
        public int? Year { get; set; }

        [JsonPropertyName("startDate")]
        public DateOnly? StartDate { get; set; }

        [JsonPropertyName("endDate")]
        public DateOnly? EndDate { get; set; }

        [JsonPropertyName("inheritedClassroomCode")]
        public string InheritedClassroomCode { get; set; }

        [JsonPropertyName("shift")]
        public Shift Shift { get; set; }

        [JsonPropertyName("grade")]
        public Grade Grade { get; set; }

    }
}
