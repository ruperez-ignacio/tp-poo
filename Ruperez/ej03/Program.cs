using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej03
{
    class password
    {
        int longitud = 8;
        public int Longitud { get { return longitud; } set { this.longitud = value; } }
        string contraseña;
        public string Contraseña { get { return contraseña; } set { this.contraseña = value; } }

        public password()
        {

        }
        public password(int longitud) 
        {
            var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789%$#@";

            var random = new Random();

            var arrayChar = new char[longitud];
            for (int i = 0; i < longitud; i++)
            {
                arrayChar[i] = characters[random.Next(characters.Length)];


            }
            var resultString = new String(arrayChar);
            this.Contraseña = resultString;
        }

        public void generarPassword()
        {
            var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789%$#@";

            var random = new Random();

            var arrayChar = new char[longitud];
            for (int i = 0; i < longitud; i++)
            {
                arrayChar[i] = characters[random.Next(characters.Length)];


            }
            var resultString = new String(arrayChar);
            this.Contraseña = resultString;
            Console.WriteLine("La contra es: " + this.Contraseña);

        }
        public void esFuerte()
        {
            int mayus = 0;
            int minus = 0;
            int num = 0;
            for (int i = 0; i < this.Contraseña.Length; i++)
            {
                if (contraseña[i] >= 97 && contraseña[i] <= 122)
                {
                    minus += 1;
                }
                else
                {
                    if (contraseña[i] >= 65 && contraseña[i] <= 90)
                    {
                        mayus += 1;
                    }
                    else
                    {
                        num += 1;
                    }
                }
            }
            if (num >= 5 && minus >= 1 && mayus >= 2)
            {

                Console.WriteLine("es fuerte");
            }
            else
            {

                Console.WriteLine("es debil");
            }
        }


        //public bool esFuerte(char c)
        //{
        //    int mayus = 0;
        //    int minus = 0;

        //    for (int i = 0; i < this.Contraseña.Length; i++)
        //    {

        //    }
        //}

    }



    class Program
    {
        static void Main(string[] args)
        {

            password password = new password();
            Console.Write("La contraseña es: " );

            password.generarPassword();
            password.esFuerte();



            Console.ReadKey();
        }
    }
}
