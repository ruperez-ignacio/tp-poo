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
        public static string[] nombres = {"Fernando", "Laura", "Pepe", "Eufrasio", "Leonardo", "Gabriel", "isaias"};

        /*Constructores*/
        public Espectador(string nombre, int edad, double dinero)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dinero = dinero;
        }

        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public int getEdad()
        {
            return edad;
        }

        public void setEdad(int edad)
        {
            this.edad = edad;
        }

        public double getDinero()
        {
            return dinero;
        }

        public void setDinero(double dinero)
        {
            this.dinero = dinero;
        }
        
        public void pagar(double precio)
        {
            dinero -= precio;
        }

        
        public bool tieneEdad(int edadMinima)
        {
            return edad >= edadMinima;
        }

        
        public bool tieneDinero(double precioEntrada)
        {
            return dinero >= precioEntrada;
        }

        public string toString()
        {
            return "el nombre del espectador es " + nombre + " de " + edad + " años y con " + dinero + " euros en su bolsillo";
        }
    }
}
