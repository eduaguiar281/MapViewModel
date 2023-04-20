using System.Text.Json.Serialization;

namespace MapViewModel.Models.Onboarding
{
    public class UserInfoResponse
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("rg")]
        public string Rg { get; set; }

        [JsonPropertyName("cpf")]
        public string Cpf { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        [JsonPropertyName("accounts")]
        public List<Account> Accounts { get; set; }

        [JsonPropertyName("birthday")]
        public string Birthday { get; set; }

        [JsonPropertyName("lastName")]
        public string LastName { get; set; }

        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("cellPhone")]
        public string CellPhone { get; set; }

        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        [JsonPropertyName("inheritedId")]
        public string InheritedId { get; set; }

        [JsonPropertyName("businessUnit")]
        public BusinessUnit BusinessUnit { get; set; }

        [JsonPropertyName("ownerBusinessUnit")]
        public string OwnerBusinessUnit { get; set; }
    }
}
