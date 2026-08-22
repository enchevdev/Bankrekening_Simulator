namespace Bankrekening_Simulator
{
    internal class Program
    {
        public static int LeesGetal()
        {

            

            while (true)
            {

                try
                {
                    int getal = int.Parse(Console.ReadLine());
                    return getal;

                }
                catch (FormatException)

                {
                    Console.WriteLine("Ongeldige invoer. Voer een geldig getal in.");
                    
                }


            }

        }
        static void Main(string[] args)
        {
            int keuze = 0;


            Bankrekening bankrekening = new Bankrekening();

            Console.WriteLine("Wat is je naam?");

            bankrekening.naam = Console.ReadLine();

            Console.WriteLine("Wat is je beginsaldo?");

            do
            {
                bankrekening.saldo = LeesGetal();

                if (bankrekening.saldo < 0)
                {
                    Console.WriteLine("Ongeldig bedrag. Voer een bedrag van 0 of hoger in.");
                }
            } while (bankrekening.saldo < 0);

            while (keuze != 4)
            {
              

                Console.WriteLine("Kies een optie:");

                    Console.WriteLine("1. Saldo bekijken");

                    Console.WriteLine("2. Geld storten");

                    Console.WriteLine("3. Geld opnemen");

                    Console.WriteLine("4. Stoppen");

                keuze = LeesGetal();
               
      

                switch (keuze)
                {
                    case 1:
                        Console.WriteLine("Hallo, " + bankrekening.naam + "! Je saldo is: " + bankrekening.saldo);
                        
                        break;

                    case 2:
                        Console.WriteLine("Hoeveel wil je storten op je saldo?");

                        int storting = LeesGetal();
                        bankrekening.Storten(storting);
                            break;

                    case 3:
                        Console.WriteLine("Hoeveel wil je opnemen?");

                            int opname = LeesGetal();
                            bankrekening.Opnemen(opname);
                            break;

                    default:

                        Console.WriteLine("Ongeldige keuze, probeer het opnieuw.");
                        break;

                    case 4:
                        Console.WriteLine("Bedankt voor het gebruiken van de Bankrekening Simulator!");
                        return;
            }   }  
        }
    }  
}