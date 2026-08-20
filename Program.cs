namespace Bankrekening_Simulator
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Bankrekening bankrekening = new Bankrekening();

            Console.WriteLine("Wat is je naam?");

            bankrekening.naam = Console.ReadLine();

            Console.WriteLine("Wat is je saldo?");

            bankrekening.saldo = int.Parse(Console.ReadLine());


            Console.WriteLine("Hallo, " + bankrekening.naam + "! Je saldo is: " + bankrekening.saldo);




        }
    }
      
}
    
