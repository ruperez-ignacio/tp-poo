using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej9
{
    class Cine
    {

        /*Atributos*/
        private double precio;
        private Pelicula pelicula;
        private Asiento[][] asientos;

        /*Constructor*/
        public Cine(int filas, int columnas, double precio, Pelicula pelicula)
        {
            asientos = new Asiento[filas][];
            this.precio = precio;
            this.pelicula = pelicula;
            rellenaButacas();
        }

        /*Metodos*/
        public Asiento[][] Asientos
        {
            set
            {
                asientos = value;
            }
            get
            {
                return asientos;
            }
        }

        public double Precio
        {
            set
            {
                precio = value;
            }
            get
            {
                return precio;
            }
        }

        public Pelicula Pelicula
        {
            set
            {
                pelicula = value;
            }
            get
            {
                return pelicula;
            }
        }

        /**
         * Rellena nuestros asientos, dandoles una fila y una letra
         */
        private void rellenaButacas()
        {

            int fila = asientos.Length;
            for (int i = 0; i < asientos.Length; i++)
            {
                for (int j = 0; j < asientos[0].Length; j++)
                {
                    //Recuerda que los char se pueden sumar
                    asientos[i][j] = new Asiento((char)('A' + j), fila);
                }
                fila--; //Decremento la fila para actualizar la fila
            }

        }

        /**
         * Indicamos si hay sitio en el cine, cuando vemos una vacia salimos de la
         * función
         *
         * @return
         */
        public bool haySitio()
        {

            for (int i = 0; i < asientos.Length; i++)
            {
                for (int j = 0; j < asientos[0].Length; j++)
                {

                    if (!asientos[i][j].ocupado())
                    {
                        return true;
                    }

                }
            }

            return false;
        }

        /**
         * Indico si en una posicion concreta esta ocupada
         *
         * @param fila
         * @param letra
         * @return
         */
        public bool haySitioButaca(int fila, char letra)
        {
            return Asiento(fila, letra).ocupado();
        }

        /**
         * Indicamos si el espectador cumple lo necesario para entrar: - Tiene
         * dinero - Tiene edad El tema de si hay sitio, se controla en el main
         *
         * @param e
         * @return
         */
        public bool sePuedeSentar(Espectador e)
        {
            if (e.tieneEdad(pelicula.EdadMinima) == true && e.tieneDinero(precio) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /**
         * Siento al espectador en un asiento
         *
         * @param fila
         * @param letra
         * @param e
         */
        public void sentar(int fila, char letra, Espectador e)
        {
            Asiento(fila, letra).Espectador = e;

        }

        /**
         * Devuelvo un asiento concreto por su fila y letra
         *
         * @param fila
         * @param letra
         * @return
         */
        public Asiento Asiento(int fila, char letra)
        {
            return asientos[asientos.Length - fila - 1][letra - 'A'];
        }

        /**
         * Numero de filas de nuestro cine
         *
         * @return
         */
        public int Filas()
        {
            return asientos.Length;
        }

        /**
         * Numero de columas de nuestro cine
         *
         * @return
         */
        public int Columnas()
        {
            return asientos[0].Length;
        }

        /**
         * Mostramos la información de nuestro cine (Tambien se puede hacer en un
         * toString pero hay que devolver un String)
         */
        public void mostrar()
        {

            Console.WriteLine("Cine: ");
            Console.WriteLine(" ");
            Console.WriteLine("Pelicula reproducida: " + pelicula);
            Console.WriteLine("Precio entrada: " + precio);
            Console.WriteLine("");

            for (int i = 0; i < asientos.Length; i++)
            {
                for (int j = 0; j < asientos[0].Length; j++)
                {
                    Console.WriteLine(asientos[i][j]);
                }
                Console.WriteLine("");
            }
        }

    }
}
