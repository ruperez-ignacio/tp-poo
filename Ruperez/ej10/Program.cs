using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creamos la baraja
            Baraja b = new Baraja();

            //Mostramos las cartas disponibles (40)
            Console.WriteLine("Hay " + b.cartasDisponible() + " cartas disponibles");

            //Saco una carta
            b.siguienteCarta();

            //Saco 5 cartas
            b.darCartas(6);

            //Mostramos las cartas disponibles (34)
            Console.WriteLine("Hay " + b.cartasDisponible() + " cartas disponibles");

            b.siguienteCarta();
            b.siguienteCarta();
            b.siguienteCarta();

            Console.WriteLine("Hay " + b.cartasDisponible() + " cartas disponibles");

            Console.WriteLine("Cartas sacadas de momento: ");

            b.cartasMonton();


            //Barajamos de nuevo
            b.barajar();

            //Saco 5 cartas
            Carta[] c = b.darCartas(5);

            Console.WriteLine("Cartas sacadas despues de barajar ");

            int cantCarta = 0;
            for (int i = 0; i < c.Length; i++)
            {
                cantCarta++;
            }
            Console.WriteLine(cantCarta);
            Console.ReadKey();
        }
    }
}
