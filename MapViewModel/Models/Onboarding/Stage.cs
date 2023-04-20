using System.Text.Json.Serialization;

namespace MapViewModel.Models.Onboarding
{

    public class Stage
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is Stage))
                return false;
            if (ReferenceEquals(obj, this))
                return false;
            Stage other = obj as Stage;

            return Name == other.Name;
        }
        public override int GetHashCode() => Name.GetHashCode();

        public static bool operator ==(Stage instanceA, Stage instanceB)
        {
            return Equals(instanceA, instanceB);
        }

        public static bool operator !=(Stage instanceA, Stage instanceB)
        {
            return !Equals(instanceA, instanceB);
        }

    }
}
