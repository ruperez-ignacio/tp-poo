using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej12
{
    internal class Jugador
    {

        private int id;
        private string nombre;
        private bool vivo;

        //Contructor
        public Jugador(int id)
        {
            this.id = id;
            nombre = "Jugador " + id;
            vivo = true;
        }

        
        public void disparar(Revolver r)
        {

            Console.WriteLine("El " + nombre + " se apunta con la pistola");

            //El jugador se pone el revolver y...
            if (r.disparar() == true)
            {
                vivo = false; //muere
                Console.WriteLine("El " + nombre + " ha muerto...");
            }
            else
            {
                Console.WriteLine("El " + nombre + " se ha librado..."); //No muere
            }

        }

        public bool isVivo()
        {
            return vivo;
        }

    }
}
