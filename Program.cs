namespace Bankrekening_Simulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string naam = "";
            int saldo = 0;


            Console.WriteLine("Wat is je naam?");

            naam = Console.ReadLine();

            Console.WriteLine("Wat is je saldo?");

            saldo = int.Parse(Console.ReadLine());


            Console.WriteLine("Hallo, " + naam + "! Je saldo is: " + saldo);

        }
    }
}
