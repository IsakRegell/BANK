namespace BANK
{
    public class BankHanterare
    {
        public DataBas databas;
        public HjälpMetoder help;

        public List<Bankkonto> bankkonton { get; set; }

        public BankHanterare(DataBas databas)
        {
            this.databas = databas;
            bankkonton = databas.AllaBankontonFrånDB!;
            HjälpMetoder help = new HjälpMetoder(databas);
        }


        public Bankkonto? Pinkod()
        {
            Console.WriteLine("Skriv in din pinkod(4 siffror): ");
            int pinkodinput = Convert.ToInt32(Console.ReadLine());

            var konto = this.bankkonton.FirstOrDefault(b => b.Pinkod == pinkodinput);
            return konto;
        }

        public void TransferMoney()
        {
            Console.WriteLine($"Hej, vänligen skriv in beloppet du vill föra över");
        }




    }
}
