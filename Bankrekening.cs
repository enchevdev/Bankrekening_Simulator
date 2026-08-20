using System;
using System.Collections.Generic;
using System.Text;

namespace Bankrekening_Simulator
{
    internal class Bankrekening
    {
        public string naam { get; set; }
        public int saldo { get; set; }


        public void Storten(int bedrag)
        {
            saldo += bedrag;
        }

        public void Opnemen(int bedrag)
        {

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
