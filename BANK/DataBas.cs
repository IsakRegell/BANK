using System.Text.Json.Serialization;

namespace BANK
{
    public class DataBas
    {
        [JsonPropertyName("Bankkonton")]
        public List<Bankkonto>? AllaBankontonFrånDB { get; set; }

    }
}
