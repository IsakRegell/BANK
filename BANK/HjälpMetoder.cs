using System.Text.Json;

namespace BANK
{
    public class HjälpMetoder
    {
        public DataBas dataBas;
        public List<Bankkonto> bankkonton { get; set; }

        public HjälpMetoder(DataBas dataBas)
        {
            this.dataBas = dataBas;
            bankkonton = dataBas.AllaBankontonFrånDB!;
        }

        public void Pausa()
        {
            Console.WriteLine("\n Tryck på en tangent för att komma till MENYN...");
            Console.ReadKey();
            Console.Clear();
        }

        public void SaveData(string dataJSONfilPath, DataBas dataBas)
        {
            string updateradedataBas = JsonSerializer.Serialize(dataBas, new JsonSerializerOptions {WriteIndented = true});
            File.WriteAllText(dataJSONfilPath, updateradedataBas);
        }

    }
}
