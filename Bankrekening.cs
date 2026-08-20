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


    }
}
