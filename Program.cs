namespace Bankrekening_Simulator
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int keuze = 0;

            Bankrekening bankrekening = new Bankrekening();

            Console.WriteLine("Wat is je naam?");

            bankrekening.naam = Console.ReadLine();

            Console.WriteLine("Wat is je beginsaldo?");

            bankrekening.saldo = int.Parse(Console.ReadLine());

            


            while (keuze != 4)
            {
            Console.WriteLine("Kies een optie:");

            Console.WriteLine("1. Saldo bekijken");

            Console.WriteLine("2. Geld storten");

            Console.WriteLine("3. Geld opnemen");

            Console.WriteLine("4. Stoppen");


             keuze = int.Parse(Console.ReadLine());

                switch (keuze)
                {
                    case 1:
                        Console.WriteLine("Hallo, " + bankrekening.naam + "! Je saldo is: " + bankrekening.saldo); ;
                        break;
                    case 2:
                        Console.WriteLine("Hoeveel wil je storten op je saldo?");
                        int storting = int.Parse(Console.ReadLine());
                        bankrekening.Storten(storting);
                        break;
                    case 3:
                        Console.WriteLine("Hoeveel wil je opnemen?");
                        int opname = int.Parse(Console.ReadLine());
                        bankrekening.Opnemen(opname);
                        break;
                    case 4:
                        Console.WriteLine("Bedankt voor het gebruiken van de Bankrekening Simulator!");
                        return;
            }   }

           
        }
    }
      
}
    
