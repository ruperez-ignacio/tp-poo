using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej9
{
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
        public char getLetra()
        {
            return letra;
        }

        public void setLetra(char letra)
        {
            this.letra = letra;
        }

        public int getFila()
        {
            return fila;
        }

        public void setFila(int fila)
        {
            this.fila = fila;
        }

        public Espectador getEspectador()
        {
            return espectador;
        }

        public void setEspectador(Espectador espectador)
        {
            this.espectador = espectador;
        }

       
        public bool ocupado()
        {
            return espectador != null;
        }

        


    }
}
