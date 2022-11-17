using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej9
{
    class Cine
    {
        Pelicula pelicula;
        double precio;
        Asiento[][] asientos;

        public Cine(int filas, int columnas, double precio, Pelicula pelicula)
        {

            asientos = new Asiento[filas][];
            this.precio = precio;
            this.pelicula = pelicula;
            rellenaButacas();
        }

            for (int c = 0; c < filas; c++)
            {
                asientos[c] = new Asiento[columnas];
            }
            this.precio = precio;
            this.pelicula = pelicula;
            Butacas();
        }
    }

    }
}
