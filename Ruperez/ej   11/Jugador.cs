using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej___11
{
    internal class Jugador
    {

        private string nombre;
        private double dinero;
        private int porrasGanadas;
        private string[] resultados;

        static Random r = new Random();

        public static Jugador[] JUGADORES ={
                                    new Jugador("Make"),
                                    new Jugador("JuanMa"),
                                    new Jugador("Fernando"),
                                    new Jugador("Alberto"),
                                    new Jugador("Lorente"),
                                    new Jugador("Adrian"),
                                    new Jugador("Maria"),
                                    new Jugador("Parra"),
                                    new Jugador("Pablo"),
                                    new Jugador("Prieto"),
                                    new Jugador("Ruben"),
                                    new Jugador("Jony"),
                                    new Jugador("Fran"),
                                    new Jugador("Isidoro"),
                                    new Jugador("Rafa")
        };

        public Jugador(string nombre)
        {
            this.nombre = nombre;
            this.dinero = 40;
            this.porrasGanadas = 0;
            this.resultados = new string[Resultados.num_partidos];
            reiniciarResultados();
        }

        public void reiniciarResultados()
        {

            for (int i = 0; i < resultados.Length; i++)
            {
                resultados[i] = "";
            }

        }

        public bool puedePagar()
        {
            return dinero >= Porra.dineroJornada;
        }

        public void ponerEnElBote()
        {
            dinero -= Porra.dineroJornada;
            Console.WriteLine("Jugador " + nombre + " ha puesto " + Porra.dineroJornada + " euro/s y le queda " + dinero + " euro/s");
        }

        public void ganarBote(double bote)
        {
            dinero += bote;
            porrasGanadas++;
            Console.WriteLine("Jugador " + nombre + " ha ganado " + bote + " euro/s y tiene " + dinero + " euro/s");
        }

        public void generarResultados()
        {

            int pLocal, pVisitante;

            for (int i = 0; i < resultados.Length; i++)
            {
                pLocal = r.Next(Resultados.resultado_minimo, Resultados.resultado_maximo);
                pVisitante = r.Next(Resultados.resultado_minimo, Resultados.resultado_maximo);

                resultados[i] = pLocal + " - " + pVisitante;


            }
        }

        public bool haAcertadoPorra(string[] resultados_partidos)
        {

            for (int i = 0; i < resultados.Length; i++)
            {
                if (resultados[i] != (resultados_partidos[i]))
                {
                    return false;
                }
            }
            return true;

        }


        
        public string toString()
        {
            return "El jugador " + nombre + " tiene dinero=" + dinero + " y ha ganado " + porrasGanadas + " porra/s";
        }

    }
}
