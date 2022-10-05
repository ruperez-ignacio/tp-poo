using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej03
{
    class password
    {
        int longitud;
        string contraseña;

        public password()
        {

        }
        public password(int longitud)
        {
            var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789%$#@";

            var random = new Random();

            longitud = 15;
            var arrayChar = new char[longitud];
            for (int i = 0; i < longitud; i++)
            {
                arrayChar[i] = characters[random.Next(characters.Length)];


            }
            var resultString = new String(arrayChar);
            this.contraseña = resultString;
            Console.WriteLine(contraseña);
        }

        public bool esFuerte()
        {
            bool s = false;
            return s;

        }

        public string Contraseña
        {
            set
            {
                contraseña = value;
            }
            get
            {
                return contraseña;
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            Console.ReadKey();
        }
    }

}