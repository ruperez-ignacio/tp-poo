using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Juego juego = new Juego(2);

            while (!juego.finJuego())
            {
                juego.ronda();
                //juego.rondaV2();
            }

            Console.WriteLine("El juego ha terminado");

            Console.ReadKey();
        }
    }
}
