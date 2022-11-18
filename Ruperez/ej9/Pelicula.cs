using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej9
{
 
    public class Pelicula
    {

        /*Atributos*/
        private String titulo;
        private int duracion;
        private int edadMinima;
        private String director;

        /*Constructor*/
        public Pelicula(String titulo, int duracion, int edadMinima, String director)
        {
            this.titulo = titulo;
            this.duracion = duracion;
            this.edadMinima = edadMinima;
            this.director = director;
        }

        /*Metodos*/
        public String Titulo
        {
            set
            {
                titulo = value;
            }
            get
            {
                return titulo;
            }
        }

        public int Duracion
        {
            set
            {
                duracion = value;
            }
            get
            {
                return duracion;
            }
        }

        public int EdadMinima
        {
            set
            {
                edadMinima = value;
            }
            get
            {
                return edadMinima;
            }
        }

        public String Director
        {
            set
            {
                director = value;
            }
            get
            {
                return director;
            }
        }

        public String toString()
        {
            return "'" + titulo + "' del director " + director + ", con una duracion de " + duracion + " minutos y la edad minima es de " + edadMinima + " años";
        }

    }

}
