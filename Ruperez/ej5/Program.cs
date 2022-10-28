using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej5
{
    interface Entregable
    {
        void entregar();
        void devolver();
        bool isEntregado();
        Entregable compareTo(Entregable e);
    }

    class serie : Entregable
    {
        string titulo;
        int temporadas = 3;
        bool entregado = false;
        string genero;
        string creador;

        public serie()
        {

        }
        public serie(string titulo, string creador)
        {
            this.titulo = titulo;
            this.creador = creador;

        }
        public serie(string titulo, int temporadas, string genero, string creador)
        {
            this.titulo = titulo;
            this.temporadas = temporadas;
            this.genero = genero;
            this.creador = creador;
        }

        public string Titulo
        {
            set { titulo = value; }
            get { return titulo; }
        }
        public int Temporada
        {
            set { temporadas = value; }
            get { return temporadas; }
        }
        public string Genero
        {
            set { genero = value; }
            get { return genero; }
        }
        public string Creador
        {
            set { creador = value; }
            get { return creador; }
        }
        public void entregar()
        {
            entregado = true;
        }

        public void devolver()
        {
            entregado = false;
        }

        public bool isEntregado()
        {
            return entregado;
            //throw new NotImplementedException();
        }

        public Entregable compareTo(Entregable e)
        {
            throw new NotImplementedException();
        }
    }

    class videojuegos : Entregable
    {
        string titulo;
        double horasest = 10;
        bool entregado = false;
        string genero;
        string compañia;

        public videojuegos()
        {

        }
        public videojuegos(string titulo, double horasest)
        {
            this.titulo = titulo;
            this.horasest = horasest;
        }
        public videojuegos(string titulo, double horasest, string genero, string compañia)
        {
            this.titulo = titulo;
            this.horasest = horasest;
            this.genero = genero;
            this.compañia = compañia;
        }

        public string Titulo
        {
            set { titulo = value; }
            get { return titulo; }
        }
        public double Horasest
        {
            set { horasest = value; }
            get { return horasest; }
        }
        public string Genero
        {
            set { genero = value; }
            get { return genero; }
        }
        public string Compañia
        {
            set { compañia = value; }
            get { return compañia; }
        }

        public Entregable compareTo(Entregable e)
        {
            throw new NotImplementedException();
        }

        public void devolver()
        {
            entregado = false;
        }

        public void entregar()
        {
            entregado = true;
        }

        public bool isEntregado()
        {
            return entregado;
        }
        //Array serie2 = new Array[];
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            serie serie1 = new serie("pol", 2, "ficcion", "Sterk");
            serie serie2 = new serie("ley", 10, "ficcion", "Sterk");
            serie serie3 = new serie("order", 7, "policial", "Tony");
            serie serie4 = new serie("ley", 11, "ficcion", "Terk");
            serie serie5 = new serie("mentalist", 8, "policial", "Sterk");

            videojuegos juego1 = new videojuegos("fortnite", 200, "shooter", "Epic Games");
            videojuegos juego2 = new videojuegos("LOL", 64, "MOBA", "Legends");
            videojuegos juego3 = new videojuegos("csgo", 200, "shooter", "Epic Games");
            videojuegos juego4 = new videojuegos("valorant", 64, "MOBA", "Legends");
            videojuegos juego5 = new videojuegos("fortnite", 200, "shooter", "Epic Games");

            serie2.entregar();
            serie1.entregar();
            juego.entregar();
            juego1.entregar();
            //serie series[0];

            //serie serieo1[1];

            Console.WriteLine(serie2.Titulo + " " + serie2.Temporada + " " + serie2.Genero + " " + serie2.Creador);
            Console.WriteLine(serie1.Titulo + " " + serie1.Temporada + " " + serie1.Genero + " " + serie1.Creador);


            Console.ReadKey();
        }
    }
}