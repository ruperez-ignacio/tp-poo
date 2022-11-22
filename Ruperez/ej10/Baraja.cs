using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej10
{
    internal class Baraja
    {
        Carta[] cartas;
        int posSiguienteCarta;
        Random r = new Random();

        //Cartas
        public static int NUM_CARTAS = 40;



        public Baraja()
        {   
            cartas = new Carta[NUM_CARTAS];
            posSiguienteCarta = 0;
            crearBaraja(); //Creamos la baraja
            barajar(); // barajamos la baraja
        }

        /**
         * Crea la baraja ordenada
         */
        private void crearBaraja()
        {

            string[] palos = Carta.PALOS;

            //Recorro los palos
            for (int i = 0; i < palos.Length; i++)
            {

                //Recorro los numeros
                for (int j = 0; j < Carta.limiteCarta; j++)
                {
                    //Las posiciones del 8 y del 9 son el 7 y el 8 (emepzamos en 8)
                    if (!(j == 7 || j == 8))
                    {
                        if (j >= 9)
                        {
                            //Solo para la sota, caballo y rey
                            cartas[((i * (Carta.limiteCarta - 2)) + (j - 2))] = new Carta(j + 1, palos[i]);
                        }
                        else
                        {
                            //Para los casos de 1 a 7
                            cartas[((i * (Carta.limiteCarta - 2)) + j)] = new Carta(j + 1, palos[i]);
                        }

                    }
                }

            }

        }
    
        /**
         * Baraja todas las cartas
         */
        public void barajar()
        {

            int posAleatoria = 0;
            Carta c;

            //Recorro las cartas
            for (int i = 0; i < cartas.Length; i++)
            {
                posAleatoria = r.Next(0, NUM_CARTAS - 1);

                //intercambio
                c = cartas[i];
                cartas[i] = cartas[posAleatoria];
                cartas[posAleatoria] = c;

            }

            //La posición vuelve al inicio
            posSiguienteCarta = 0;

        }

        /**
         * Devuelve la casta donde se encuentre "posSiguienteCarta"
         * @return carta del arreglo
         */
        public Carta siguienteCarta()
        {

            Carta c = null;

            if (posSiguienteCarta == NUM_CARTAS)
            {
                Console.WriteLine("Ya no hay mas cartas, barajea de nuevo");
            }
            else
            {
                c = cartas[posSiguienteCarta++];
            }

            return c;

        }

        /**
         * Devuelve un numero de cartas. Controla si hay mas cartas de las que se piden 
         * @param numCartas
         * @return 
         */
        public Carta[] darCartas(int numCartas)
        {
            if (numCartas > NUM_CARTAS)
            {
                Console.WriteLine("No se puede dar mas cartas de las que hay");
            }
            else if (cartasDisponible() < numCartas)
            {
                Console.WriteLine("No hay suficientes cartas que mostrar");
            }
            else
            {

                Carta[] cartasDar = new Carta[numCartas];

                //recorro el array que acabo de crear para rellenarlo
                for (int i = 0; i < cartasDar.Length; i++)
                {
                    cartasDar[i] = siguienteCarta(); //uso el metodo anterior
                }

                //Lo devuelvo
                return cartasDar;

            }

            //solo en caso de error
            return null;

        }

        /**
         * Indica el numero de cartas que hay disponibles
         * @return 
         */
        public int cartasDisponible()
        {
            return NUM_CARTAS - posSiguienteCarta;
        }

        /**
         * Muestro las cartas que ya han salido
         */
        public void cartasMonton()
        {
            if (cartasDisponible() == NUM_CARTAS)
            {
                Console.WriteLine("No se ha sacado ninguna carta");
            }
            else
            {
                int cantCarta = 0;
                for (int i = 0; i < posSiguienteCarta; i++)
                {
                    cantCarta++;
                }
                Console.WriteLine(cantCarta);
            }
        }

        /**
         * Muestro las cartas que aun no han salido
         */
        public void mostrarBaraja()
        {

            if (cartasDisponible() == 0)
            {
                Console.WriteLine("No hay cartas que mostrar");
            }
            else
            {
                for (int i = posSiguienteCarta; i < cartas.Length; i++)
                {
                    Console.WriteLine(cartas[i]);
                }
            }

        }

    }
}

