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
            for (int c = 0; c < filas; c++)
            {
                asientos[c] = new Asiento[columnas];
            }
            this.precio = precio;
            this.pelicula = pelicula;
            rellenaButacas();
        }

        /*Metodos*/
        public Asiento[][] getAsientos()
        {
            return asientos;
        }

        public void setAsientos(Asiento[][] asientos)
        {
            this.asientos = asientos;
        }

        public double getPrecio()
        {
            return precio;
        }

        public void setPrecio(double precio)
        {
            this.precio = precio;
        }

        public Pelicula getPelicula()
        {
            return pelicula;
        }

        public void setPelicula(Pelicula pelicula)
        {
            this.pelicula = pelicula;
        }

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
                fila--; 
            }

        }

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

       
        public bool haySitioButaca(int fila, char letra)
        {
            return Asiento(fila, letra).ocupado();
        }

        public bool sePuedeSentar(Espectador e)
        {
            if (e.tieneEdad(pelicula.getEdadMinima()) == true && e.tieneDinero(precio) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void sentar(int fila, char letra, Espectador e)
        {
            Asiento(fila, letra).setEspectador(e);

        }

        public Asiento Asiento(int fila, char letra)
        {
            return asientos[asientos.Length - fila - 1][letra - 'A'];
        }

        public int getFilas()
        {
            return asientos.Length;
        }

        public int getColumnas()
        {
            return asientos[0].Length;
        }
        
        public void mostrar()
        {

            Console.WriteLine("Cine: ");
            Console.WriteLine("Pelicula reproducida: " + pelicula.getTitulo());
            Console.WriteLine("Precio entrada: " + precio);
            Console.WriteLine("");

            for (int i = 0; i < asientos.Length; i++)
            {
                for (int j = 0; j < asientos[0].Length; j++)
                {
                  
                    Console.Write(asientos[i][j].getFila() + " " + asientos[i][j].getLetra());

                }
                Console.WriteLine();
            }
        }

    }
}
