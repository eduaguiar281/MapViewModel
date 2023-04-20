using System.Text.Json.Serialization;

namespace MapViewModel.Models.Onboarding
{
    public class Institution
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("cnpj")]
        public string Cnpj { get; set; }

        [JsonPropertyName("companyName")]
        public string CompanyName { get; set; }

        [JsonPropertyName("businessUnit")]
        public BusinessUnit BusinessUnit { get; set; }

        [JsonPropertyName("parentInstitution")]
        public Institution ParentInstitution { get; set; }

        [JsonPropertyName("inheritedSchoolCode")]
        public string InheritedSchoolCode { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is Institution))
                return false;
            if (ReferenceEquals(obj, this))
                return false;
            Institution other = obj as Institution;

            return InheritedSchoolCode == other.InheritedSchoolCode;
        }
        public override int GetHashCode() => Id.GetHashCode();

        public static bool operator ==(Institution instanceA, Institution instanceB)
        {
            return Equals(instanceA, instanceB);
        }

        public static bool operator !=(Institution instanceA, Institution instanceB)
        {
            return !Equals(instanceA, instanceB);
        }
    }
}
