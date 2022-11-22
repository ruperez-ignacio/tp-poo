using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej10
{
    internal class Carta
    {
        int numero;
        string palo;

        public static  string[] PALOS={"ESPADAS", "OROS", "COPAS", "BASTOS"};
        public static int limiteCarta = 12;

        public Carta(int numero, string palo)
        {
            this.numero = numero;
            this.palo = palo;
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Palo
        {
            get { return palo; }
            set { palo = value; }
        }
    }
}
