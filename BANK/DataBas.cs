using System.Text.Json.Serialization;

namespace BANK
{
    public class DataBas
    {
        [JsonPropertyName("Bankkonton")]
        public List<Bankkonto>? AllaBankontonFrånDB { get; set; }

        [JsonPropertyName("transactionList")]
        public List<Transaction>? transactionList { get; set; }

    }

}
