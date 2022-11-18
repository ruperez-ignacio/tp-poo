using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej9
{
    /**
 * Clase asiento, se usa para manejar toda la informacion relativa al asiento
 *
 * @author DiscoDurodeRoer
 */
    class Asiento
    {

        /*Atributos*/
        private char letra;
        private int fila;
        private Espectador espectador;

        /*Constructores*/
        public Asiento(char letra, int fila)
        {
            this.letra = letra;
            this.fila = fila;
            this.espectador = null; //al iniciar el asiento, no habrá nadie sentado
        }

        /*Metodos*/
        public char Letra
        {
            set
            {
                letra = value;  
            }
            get
            {
                return letra;
            }
        }
        public int Fila
        {
            set
            {
                fila = value;
            }
            get
            {
                return fila;
            }
        }
        public Espectador Espectador
        {
            set
            {
                espectador = value;
            }
            get
            {
                return espectador;
            }
        }

        public bool ocupado()
        {
            return espectador != null;
        }

        public String toString()
        {
            if (ocupado())
            {
                return "Asiento: " + fila + letra + " y " + espectador;
            }

            return "Asiento: " + fila + letra + " y este asiento está vacio ";

        }


    }
}
