using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej9
{
    class Espectador
    {
        private string nombre;
        private int edad;
        private double dinero;
        public static string[] nombres = {"Fernando", "Laura", "Pepe", "Eufrasio"};

        /*Constructores*/
        public Espectador(String nombre, int edad, double dinero)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dinero = dinero;
        }

        /*Metodos*/
        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }

        public int Edad
        {
            set
            {
                edad = value;
            }
            get
            {
                return edad;
            }
        }

        public double Dinero
        {
            set
            {
                dinero = value;
            }
            get
            {
                return dinero;
            }
        }
        /**
         * Pagamos la entrada del cine
         *
         * @param precio
         */
        public void pagar(double precio)
        {
            dinero -= precio;
        }

        /**
         * Indicamos si el espectador tiene edad para ver la pelicula (en el video
         * estaba en la clase pelicula tiene mas sentido que sea un metodo del
         * espectador)
         *
         * @param edadMinima
         * @return
         */
        public bool tieneEdad(int edadMinima)
        {
            return edad >= edadMinima;
        }

        /**
         * Indicamos si el espectador tiene dinero (en el video estaba en la clase
         * cine tiene mas sentido que sea un metodo del espectador)
         *
         * @param precioEntrada
         * @return
         */
        public bool tieneDinero(double precioEntrada)
        {
            return dinero >= precioEntrada;
        }

        public String toString()
        {
            return "el nombre del espectador es " + nombre + " de " + edad + " años y con " + dinero + " euros en su bolsillo";
        }
    }
}
