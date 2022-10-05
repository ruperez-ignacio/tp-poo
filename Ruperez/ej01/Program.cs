using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ej01
{
    public class Cuenta
    {
        private string titular;
        private double cantidad;
        private double retirarc;

        public Cuenta(string titular)
        {
            this.titular = titular;
        }
        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        
        public void ingresar(double cant)
        {
            if (cant >= 0)
            {
                cantidad += cant;
            }
        }

        public void retirar(float cant)
        {
            retirarc = cantidad - cant;
            if (retirarc < 0)
            {
                cantidad = 0;
            }
        }

        public string Titular
        {
            set
            {
                titular = value;
            }
            get
            {
                return titular;
            }
        }

        public double Cantidad
        {

            set
            {
                cantidad = value;
            }
            get
            {
                return cantidad;
            }
        }

    }


    class Program
    {

        static void Main(string[] args)
        {

            Cuenta c1 = new Cuenta("Nacho", 257);

            c1.ingresar(1000);
            c1.ingresar(-1000);

            c1.retirar(1000000);
            

            Console.WriteLine(c1.Titular + " tiene " + c1.Cantidad+"$");

            Console.ReadKey();


        }
    }
}
