using System.Text.Json.Serialization;

namespace MapViewModel.Models.Onboarding
{
    public class BusinessUnit
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("realmName")]
        public string RealmName { get; set; }

        [JsonPropertyName("businessUnitType")]
        public BusinessUnitType BusinessUnitType { get; set; }

        [JsonPropertyName("partnerIntegrationKeys")]
        public List<PartnerIntegrationKey> PartnerIntegrationKeys { get; set; }
    }
}
