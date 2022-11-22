using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej___11
{
    internal class Resultados
    {

        string[] partidos;
        public static int num_partidos = 2;
        public static int resultado_minimo = 0;
        public static int resultado_maximo = 3;
        Random r = new Random();
        public Resultados()
        {
            partidos = new string[num_partidos];
        }
        public void generarResultados()
        {

            int pLocal, pVisitante;

            for (int i = 0; i < partidos.Length; i++)
            {
                //Generamos los resultados
                pLocal = r.Next(resultado_minimo, resultado_maximo);
                pVisitante = r.Next(resultado_minimo, resultado_maximo);

                partidos[i] = pLocal + " - " + pVisitante;

                Console.WriteLine("El partido " + (i + 1) + " ha generado el resultado " + partidos[i]);
            }

        }
        public string[] Partidos
        {
            get
            {
                return partidos;
            }
        }


    }
}
