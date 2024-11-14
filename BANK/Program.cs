using System.Text;
using System.Text.Json;

namespace BANK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dataJSONfilPath = "BankData.json";// Ange sökvägen till JSON-filen

            string allaDataSomJSONType = File.ReadAllText(dataJSONfilPath);// Läs JSON-innehållet från filen

            DataBas databas = JsonSerializer.Deserialize<DataBas>(allaDataSomJSONType)!;// Deserialisera JSON-innehållet till ett DataBas-objekt

            BankHanterare bankHanterare = new BankHanterare(databas);
            HjälpMetoder help = new HjälpMetoder(databas);


            bool ProgramIsRuning = true;

            while (ProgramIsRuning)
            {
                Bankkonto? konto = bankHanterare.Pinkod(); //Jämför pinkod med konton

                if (konto != null)
                {
                    bool BigProgram = true;
                    Console.Clear();
                    Console.WriteLine($"Välkommen tillbaka *{konto.Namn}*!\n");

                    while (BigProgram)
                    {
                        Console.WriteLine("---Detta är din Bankmeny---");
                        Console.WriteLine("Tryck (1) för att kolla ditt saldo");
                        Console.WriteLine("Tryck (2) för överföra pengar");
                        Console.WriteLine("Tryck (3) för att redigera din kontoinfo");
                        Console.WriteLine("Tryck (4) för att logga ut");
                        Console.WriteLine("Tryck (9) för att stänga av programet");
                        string menuoptionONE = Console.ReadLine()!;

                        switch (menuoptionONE)
                        {
                            case "1":
                                Console.Clear();
                                Console.WriteLine($"Ditt saldo är: {konto.Saldo} kr");
                                help.Pausa();
                                break;

                            case "2":
                                bankHanterare.TransferMoney();
                                help.Pausa();
                                break;

                            case "3":
                                bankHanterare.EditAccountName();
                                help.Pausa();   
                                break;

                            case "4":
                                Console.WriteLine("Du har loggat ut");
                                BigProgram = false;
                                break;

                            case "9":
                                Console.WriteLine("Programmet är avslutat");
                                BigProgram = false;
                                ProgramIsRuning = false;


                                break;

                            default:
                                Console.WriteLine("Ogiltigt val. Vänligen försök igen.");
                                break;
                        }
                    }

                }


                else
                {
                    Console.WriteLine("Felaktig pinkod. Försök igen.");
                }
            }


        }

    }
}
