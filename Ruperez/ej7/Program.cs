using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej7
{
    class Raices
    {
        double a;
        double b;
        double c;

        public Raices()
        {

        }
        public Raices (double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        //s = solucion
        //us = unica solucion
        public void obtenerRaices()
        {
            double s1 = (- b + Math.Sqrt(getDiscriminante())) / (2 * a);
            double s2 = (- b - Math.Sqrt(getDiscriminante())) / (2 * a);

            Console.WriteLine("Primera solucion: " + s1);
            Console.WriteLine("Segunda solucion: " + s2);

        }
        public void obtenerRaiz()
        {
            double us = (-b) / (2 * a);

            Console.WriteLine("La unica posible solucion es: " + us);

        }
        public double getDiscriminante()
        {
            double dis = (Math.Pow(b, 2) - (4 * a * c));
            return dis;
        }
        public bool tieneRaices()
        {
            return getDiscriminante() > 0;
        }
        public bool tieneRaiz()
        {
            return getDiscriminante() == 0;
        }
        public void calcular()
        {
            if (tieneRaices())
            {
                obtenerRaices();
            }
            else if (tieneRaiz())
            {
                obtenerRaiz();
            }
            else
            {
                Console.WriteLine("No tiene raices");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Raices valores = new Raices(20, 43, 13.8);

            valores.calcular();
        }
    }
}
