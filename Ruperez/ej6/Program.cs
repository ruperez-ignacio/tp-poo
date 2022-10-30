using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej6
{
    class Libro
    {
        string isbn;
        string titulo;
        string autor;
        int paginas;

        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }
        public string Titulo
        {
            get { return titulo; } 
            set { titulo = value; }
        }
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        public int Paginas
        {
            get { return paginas; }
            set { paginas = value; }
        }

        public Libro()
        {

        }
        public Libro(string isbn, string titulo, string autor, int paginas)
        {
            this.isbn = isbn;
            this.titulo = titulo;
            this.autor = autor;
            this.paginas = paginas;
        }

        public void libros()
        {
            Console.WriteLine("El libro {0} con ISBN {1} creado por el autor {2} tiene {3} páginas", Titulo, ISBN, Autor, Paginas);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro("860-059707051-0", "futbol", "flora", 120);
            Libro libro2 = new Libro("695-291272991-0", "ficcion", "Borges", 140);

            libro1.libros();
            libro2.libros();
            Console.WriteLine();

            if(libro1.Paginas > libro2.Paginas)
            {
                Console.WriteLine("El libro '{0}' tiene mas paginas que el libro '{1}'", libro1.Titulo, libro2.Titulo);
            }else
            {
                Console.WriteLine("El libro '{0}' tiene mas paginas que el libro '{1}'", libro2.Titulo, libro1.Titulo);
            }

            Console.ReadKey();
        }
    }
}
