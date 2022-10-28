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
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            serie serie0 = new serie("pol", 2, "ficcion", "Sterk");
            serie serie1 = new serie("ley", 10, "ficcion", "Sterk");
            serie serie2 = new serie("order", 7, "policial", "Tony");
            serie serie3 = new serie("ley", 11, "ficcion", "Terk");
            serie serie4 = new serie("mentalist", 8, "policial", "Sterk");

            videojuegos juego0 = new videojuegos("fortnite", 200, "shooter", "Epic Games");
            videojuegos juego1 = new videojuegos("LOL", 64, "MOBA", "Legends");
            videojuegos juego2 = new videojuegos("csgo", 200, "shooter", "Epic Games");
            videojuegos juego3 = new videojuegos("valorant", 64, "MOBA", "Legends");
            videojuegos juego4 = new videojuegos("fortnite", 200, "shooter", "Epic Games");

            serie[] series = {serie0, serie1, serie2, serie3, serie4};

            videojuegos[] videojuegos = {juego0, juego1, juego2, juego3, juego4};

            juego0.entregar();
            juego1.entregar();
            juego3.entregar();

            serie0.entregar();
            serie1.entregar();
            serie2.entregar();
            serie4.entregar();

            int entregados = 0;

            for (int i = 0; i < series.Length; i++)
            {
                if (series[i].isEntregado())
                {
                    entregados += 1;

                }
                if (videojuegos[i].isEntregado())
                {
                    entregados += 1;
                }
            }

            Console.WriteLine("hay entregados: " + entregados);


            Console.ReadKey();
        }
    }
}