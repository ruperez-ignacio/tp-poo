using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Pelicula pelicula = new Pelicula("Batman", 112, 14, "mla");

            // No valida nada al respecto de tamaños (siguiente version)

            Console.WriteLine("Introduce el numero de filas");
            int filas = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el numero de columnas");
            int columnas = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el precio de la entrada de cine");
            double precio = double.Parse(Console.ReadLine());

            //Creo el cine, necesito la pelicula para ello
            Cine cine = new Cine(filas, columnas, precio, pelicula);

            //Numero de espectadores que seran creados
            Console.WriteLine("Introduce el numero de espectadores a crear");
            int numEspectadores = int.Parse(Console.ReadLine());


            //Variables y objetos usados
            Espectador e;
            int fila;
            char letra;
            int c = 0;

            Console.WriteLine("Espectadores generados: ");
            for (int i = 0; i < (cine.Columnas * cine.Filas); i++)
            {
                e = new Espectador(Espectador.nombres[r.Next(0, Espectador.nombres.Length - 1)], r.Next(10, 30), r.Next(1, 15));
                cine.mostrar();

                do
                {
                    fila = r.Next(0, cine.Filas - 1);
                    letra = (char)r.Next('A', 'A' + cine.Columnas - 1);
                } while (!cine.haySitioButaca(fila, letra));

                if (cine.sePuedeSentar(e))
                {
                    e.pagar(precio);
                    cine.sentar(fila, letra, e);

                    c++;
                    Console.WriteLine("\n" + e.Nombre);
                    Console.WriteLine(e.Edad);
                    Console.WriteLine(e.Dinero + cine.Precio);

                }
            }

            Console.WriteLine("");
            cine.mostrar(); //Mostramos la información del cine, tambien se puede usar un toString

            Console.WriteLine("Fin");

        }

    }
    }

