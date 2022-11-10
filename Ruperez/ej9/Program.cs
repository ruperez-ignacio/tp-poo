using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej9
{
    class cine
    {
        string pelicula;
        double precio;
    }

    class peliculas
    {
        string titulo;
        int duracion;
        int edadMinima;
        string director;
    }

    class espectador
    {
        string nombre;
        int edad;
        double dinero;

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                edad = value;
            }
        }
        public double Dinero
        {
            get
            {
                return dinero;
            }
            set
            {
                dinero = value;
            }
        }
        public espectador(string nombre, int edad, double dinero)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dinero = dinero;
        }
    }

    class asientos
    {
        char letra;
        int fila;
        espectador espectador;

        public asientos(char letra, int fila)
        {
            this.letra = letra;
            this.fila = fila;
            this.espectador = null; 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
