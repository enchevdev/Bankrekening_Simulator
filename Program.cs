namespace Bankrekening_Simulator
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Bankrekening bankrekening = new Bankrekening();

            Console.WriteLine("Wat is je naam?");

            bankrekening.naam = Console.ReadLine();

            Console.WriteLine("Wat is je beginsaldo?");

            bankrekening.saldo = int.Parse(Console.ReadLine());

            Console.WriteLine("Hoeveel wil je storen op je saldo?");

            int bedrag = int.Parse(Console.ReadLine());

            bankrekening.Storten(bedrag);

            Console.WriteLine("Hallo, " + bankrekening.naam + "! Je saldo is: " + bankrekening.saldo);
        }
    }
      
}
    
