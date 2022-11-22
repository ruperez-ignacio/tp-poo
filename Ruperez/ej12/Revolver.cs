using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej12
{
    internal class Revolver
    {
        int posicionActual;
        int posicionBala;
        Random r = new Random();

        public Revolver()
        {
            posicionActual = r.Next(1, 6);
            posicionBala = r.Next(1, 6);
        }

        public bool disparar()
        {
            if(posicionActual == posicionBala)
            {
                siguienteBala();
                return true;
            }
            else 
            {
                siguienteBala();
                return false;
            }
        }

        public void siguienteBala()
        {
            if (posicionActual == 6)
            {
                posicionActual = 1; 
            }
            else
            {
                posicionActual++;
            }
        }
    }
}
