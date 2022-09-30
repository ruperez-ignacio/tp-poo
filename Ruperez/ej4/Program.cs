using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej4
{
    public class Electrodomestico
    {
        double precioBase = 100;
        string color = "blanco";
        char consumo = 'F';
        double peso = 5;

        public Electrodomestico()
        {

        }

        public Electrodomestico(double precioBase, double peso)
        {
            this.precioBase = precioBase;
            this.peso = peso;
        }

        public Electrodomestico(double precioBase, string color, char consumo, double peso)
        {
            this.precioBase = precioBase;
            this.color = color;
            this.consumo = consumo;
            this.peso = peso;
        }

        public double PrecioBase
        {
            set
            {
                precioBase = value;
            }
            get
            {
                return precioBase;
            }
        }
        public string Color
        {

            set
            {
                color = value;
            }
            get
            {
                return color;
            }
        }
        public char Consumo
        {
            set
            {
                consumo = value;
            }
            get
            {
                return consumo;
            }
        }
        public double Peso
        {

            set
            {
                peso = value;
            }
            get
            {
                return peso;
            }
        }

        public void comprobarConsumoEnergetico(char letra)
        {
            if(letra == 'F' || letra == 'f')
            {
                consumo = 'F';
            }else if (letra == 'A' || letra == 'a'){
                consumo = 'A';
            }
            else
            {
                consumo = 'F';
            }
        }

        public void comprobarColor(String color)
        {
            if (color == "blanco")
            {
                color = "blanco";
            }
            else
            {
                color = "blanco";
            }
        }

        public void precioFinal()
        {

            
                double plus = 0;
                switch (consumo)
                {
                    case 'A':
                        plus += 100;
                        break;
                    case 'B':
                        plus += 80;
                        break;
                    case 'C':
                        plus += 60;
                        break;
                    case 'D':
                        plus += 50;
                        break;
                    case 'E':
                        plus += 30;
                        break;
                    case 'F':
                        plus += 10;
                        break;
                }
                if (peso >= 0 && peso < 19)
                {
                    plus += 10;
                }
                else if (peso >= 20 && peso < 49)
                {
                    plus += 50;
                }
                else if (peso >= 50 && peso <= 79)
                {
                    plus += 80;
                }
                else if (peso >= 80)
                {
                    plus += 100;
                }
        }
    }

    public class Lavadora : Electrodomestico
    {
        double carga = 5;

        public Lavadora()
        {

        }
        public Lavadora(double precioBase, double peso) : base(precioBase, peso)
        {
            this.PrecioBase = precioBase;
            this.Peso = peso;
        }
        public Lavadora(double carga, double precioBase, string color, char consumo, double peso) : base(precioBase, color, consumo, peso)
        {
            this.carga = carga;
            this.PrecioBase = precioBase;
            this.Color = color;
            this.Consumo = consumo;
            this.Peso = peso;
        }

        public double Carga
        {
            set
            {
                carga = value;
            }
            get
            {
                return carga;
            }
        }

        public void precioFinal()
        {
            if(carga > 30)
            {
                PrecioBase += 50;
            }
            else
            {
                PrecioBase = PrecioBase;
            }
        }
    }

    public class television : Electrodomestico
    {
        double resolucion = 20;
        bool TDT = false;


    }


    class Program
    {
        static void Main(string[] args)
        {
        //    Console.WriteLine("introduci nombre");
        //    string nombre = (Console.ReadLine());
        //    Console.WriteLine("introduci edad");
        //    int edad = int.Parse(Console.ReadLine());
        //    Console.WriteLine("introduci sexo");
        //    char sexo = char.Parse(Console.ReadLine());
        //    Console.WriteLine("introduci peso");
        //    double peso = double.Parse(Console.ReadLine());
        //    Console.WriteLine("introduci altura");
        //    double altura = double.Parse(Console.ReadLine());
            //new Lavadora(100, 1.0); 
        }
    }
}
