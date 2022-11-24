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

            Console.WriteLine("Espectadores generados: ");
            for (int i = 0; i < numEspectadores && cine.haySitio(); i++)
            {

                //Generamos un espectador
                e = new Espectador(
                        Metodos.nombres[Metodos.generaNumeroEnteroAleatorio(0, Metodos.nombres.Length)], //Nombre al azar
                        Metodos.generaNumeroEnteroAleatorio(10, 30), //Generamos una edad entre 10 y 30
                        Metodos.generaNumeroEnteroAleatorio(1, 10)); //Generamos el dinero entre 1 y 10 euros

                //Mostramos la informacion del espectador
                Console.WriteLine("Nombre: " + e.getNombre() + " Edad: " + e.getEdad());

                //Generamos una fila y letra
                //Si esta libre continua sino busca de nuevo
                do
                {

                    fila = Metodos.generaNumeroEnteroAleatorio(0, cine.getFilas() - 1);
                    letra = (char)Metodos.generaNumeroEnteroAleatorio('A', 'A' + (cine.getColumnas()));

                } while (cine.haySitioButaca(fila, letra));

                //Si el espectador cumple con las condiciones
                if (cine.sePuedeSentar(e))
                {
                    e.pagar(cine.getPrecio()); //El espectador paga el precio de la entrada
                    cine.sentar(fila, letra, e); //El espectador se sienta
                }

            }

            Console.WriteLine("");
            cine.mostrar(); //Mostramos la información del cine, tambien se puede usar un toString
            Console.ReadKey();
            Console.WriteLine("Fin");


        }

    }
    }

