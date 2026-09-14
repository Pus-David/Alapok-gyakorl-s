using System;
using System.Collections.Generic;
using System.Text;

namespace WebaruhazTermek
{
    internal class Termek
    {
        public string Nev { get; set; }
        public int Egysegar 
        {
            get { return Egysegar; }
            set
            {
                if (value < 0) Egysegar = 1;
            }
        }

        public int Keszlet
        {
            get { return Keszlet; }
            set
            {
                if (value < 0) Keszlet = 0;
            }
        }



    }
}
