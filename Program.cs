namespace Bankrekening_Simulator
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int keuze = 0;
            bool geldigeInvoer = false;

            Bankrekening bankrekening = new Bankrekening();

            Console.WriteLine("Wat is je naam?");

            bankrekening.naam = Console.ReadLine();

            Console.WriteLine("Wat is je beginsaldo?");

            while (!geldigeInvoer)
            {
                try

                {
                    bankrekening.saldo = int.Parse(Console.ReadLine());
                    geldigeInvoer = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ongeldige invoer. Voer een geldig getal in.");
                    continue;
                }

                if (bankrekening.saldo < 0)
                {
                    Console.WriteLine("Ongeldig bedrag. Voer een bedrag van 0 of hoger in.");
                    geldigeInvoer = false;
                }
            }

            while (keuze != 4)
            {
              

                Console.WriteLine("Kies een optie:");

                    Console.WriteLine("1. Saldo bekijken");

                    Console.WriteLine("2. Geld storten");

                    Console.WriteLine("3. Geld opnemen");

                    Console.WriteLine("4. Stoppen");

                try
                {
                    keuze = int.Parse(Console.ReadLine());

                }
                catch (FormatException)

                {
                    Console.WriteLine("Ongeldige invoer. Voer een geldig getal in.");
                    continue;
                }
      

                switch (keuze)
                {
                    case 1:
                        Console.WriteLine("Hallo, " + bankrekening.naam + "! Je saldo is: " + bankrekening.saldo); ;
                        
                        break;
                    case 2:
                        Console.WriteLine("Hoeveel wil je storten op je saldo?");

                        
                        try
                        {
                            int storting = int.Parse(Console.ReadLine());
                            bankrekening.Storten(storting);
                            break;
                        }

                        catch (FormatException)
                        {
                            Console.WriteLine("Ongeldige invoer. Voer een geldig getal in.");
                            continue;
                        }
                        
                    case 3:
                        Console.WriteLine("Hoeveel wil je opnemen?");


                        try
                        {
                            int opname = int.Parse(Console.ReadLine());
                            bankrekening.Opnemen(opname);
                            break;

                        }

                        catch (FormatException)
                        {
                            Console.WriteLine("Ongeldige invoer. Voer een geldig getal in.");
                            continue;
                        }

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
    
