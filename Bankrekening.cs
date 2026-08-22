namespace Bankrekening_Simulator
{
    internal class Bankrekening
    {
        public string naam { get; set; }
        public int saldo { get; set; }


        public void Storten(int bedrag)
        {
            if (bedrag <= 0)
            {

                Console.WriteLine("Ongeldig bedrag. Voer een positief getal in.");
                return;
            }
            saldo += bedrag;


        }

        public void Opnemen(int bedrag)
        {

            if (bedrag <= 0)
            {
                Console.WriteLine("Ongeldig bedrag. Voer een positief getal in.");
                return;
            }

            if (saldo >= bedrag)
            {
                saldo -= bedrag;

                Console.WriteLine("Je hebt " + saldo + " euro op je rekening.");

            }

            else
            {
                Console.WriteLine("Je hebt niet genoeg geld op je rekening.");
            }
        }
    }
}
