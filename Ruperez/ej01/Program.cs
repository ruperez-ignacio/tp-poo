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
        private double cantidadRetiro;

       public Cuenta(string titular)
        {
            this.titular = titular;
        }
        public Cuenta(string titular, double cantidad, double cantidadRetiro)
        {
            this.titular = titular;
            this.cantidad = cantidad;
            this.cantidadRetiro = cantidadRetiro;
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
        public double CantidadRetiro
        {
            set
            {
                cantidadRetiro = value;
            }
            get
            {
                return cantidadRetiro;
            }
        }
         public void ingresar(double cantidad)
        {

        }
    }
    

    class Program
    {

        static void Main(string[] args)
        {
            
            Console.ReadKey();


        }
    }
}
