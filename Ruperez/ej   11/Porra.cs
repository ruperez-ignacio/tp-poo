using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej___11
{
    internal class Porra
    {

        private double bote;
        public static int dineroJornada = 1;
        public static int numeroJornadas = 6;

        public Porra()
        {
            bote = 0;
        }

        /**
         * Aumenta la cantidad del bote
         * @param dinero 
         */
        public void aumentarBote(double dinero)
        {
            bote += dinero;
        }

        /**
         * Dejamos el bote a 0
         */
        public void vacirBote()
        {
            bote = 0;
        }

        /**
         * Metodo principal que simula el transcurso de la porra
         */
        public void jornadas()
        {

            Resultados resultados = new Resultados();
            string[] partidos;

            //Recorremos las jornadas
            for (int i = 0; i < numeroJornadas; i++)
            {

                Console.WriteLine("JORNADA " + (i + 1));
                Console.WriteLine("");

                //Apuesta
                for (int j = 0; j < Jugador.JUGADORES.Length; j++)
                {
                    //Si un jugador puede pagar
                    if (Jugador.JUGADORES[j].puedePagar())
                    {
                        //el jugador paga, dice sus resultados y el bote se aumenta
                        Jugador.JUGADORES[j].ponerEnElBote();
                        Jugador.JUGADORES[j].generarResultados();
                        aumentarBote(dineroJornada);
                    }
                    else
                    {
                        //Si no puede pagar, los resultados se vacian
                        Jugador.JUGADORES[j].reiniciarResultados();
                    }

                }


                //Partido
                resultados.generarResultados();
                partidos = resultados.Partidos;

                //Comprobacion
                for (int j = 0; j < Jugador.JUGADORES.Length; j++)
                {
                    //Indica si ha acertado
                    if (Jugador.JUGADORES[j].haAcertadoPorra(partidos))
                    {
                        //Le damos el bota al jugador y vaciamos el bote
                        Jugador.JUGADORES[j].ganarBote(bote);
                        vacirBote();
                    }

                }

            }
        }
    }
}
