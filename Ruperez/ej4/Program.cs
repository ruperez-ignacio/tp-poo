using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            //string s = "asd1";
            //// Define the regular expression pattern.            
            //bool res = Regex.IsMatch(s, @"^[a-fA-F]+$");
            //Console.WriteLine(res);

            if (letra > 65 && letra < 70 || letra > 97 && letra < 102)
            {
                consumo = letra;

            }
            else
            {
                consumo = 'F';
            }
        }

        public void comprobarColor(String color)
        {
            string[] colors = { "blanco", "negro", "rojo", "azul", "gris" };
            bool encontrado = false; //si es false muestra el valor por defecto
            for (int i = 0; i < colors.Length; i++)
            {
                if (colors[i].Equals(colors))
                {
                    encontrado = true;//si es verdadero mostrara el valor de color
                }
            }
            
        }

        public virtual void precioFinal()
        {

            
                double plus = 0;
                switch (precioBase)
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

        public override void precioFinal()
        {
            if(carga > 30)
            {
                PrecioBase += 50;
            }
        }
    }

    public class television : Electrodomestico
    {
        double resolucion = 20;
        bool tdt = false;

        public television()
        {

        }
        public television(double precioBase, double peso)
        {
            this.PrecioBase = precioBase;
            this.Peso = peso;
        }
        public television(double resolucion, bool tdt, double precioBase, string color,
            char consumo, double peso) : base(precioBase, color, consumo, peso)
        {
            this.resolucion = resolucion;
            this.tdt = tdt;
            this.PrecioBase = precioBase;
            this.Color = color;
            this.Consumo = consumo;
            this.Peso = peso;
        }
        public double Resolucion
        {
            set
            {
                resolucion = value;
            }
            get
            {
                return resolucion;
            }
        }
        public bool Tdt
        {
            set
            {
                tdt = value;
            }
            get
            {
                return tdt;
            }
        }

        public void precioFinal()
        {
            if (Resolucion > 40)

            {   
                PrecioBase = PrecioBase * 1.30;

                if (Tdt == true)
                {
                    PrecioBase = PrecioBase + 50;
                }

            }
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Lavadora lavadora0 = new Lavadora(100, 30);
            Lavadora lavadora1 = new Lavadora(500, 40);
            Lavadora lavadora2 = new Lavadora(600, 50);
            Lavadora lavadora3 = new Lavadora(700, 60);
            Lavadora lavadora4 = new Lavadora(250, 70);

            television television0 = new television(20, 10);
            television television1 = new television(35,49);
            television television2 = new television(65, 87);
            television television3 = new television(133, 20);
            television television4 = new television(100, 80);




            Electrodomestico[] electrodomesticos = {lavadora0, lavadora1, lavadora2, lavadora3 ,lavadora4, television0, television1 , television2, television3, television4};

            double sumaTelevisiones = 0;
            double sumaLavadoras = 0;

            //Recorremos el array invocando el metodo precioFinal
            for (int i = 0; i < electrodomesticos.Length; i++)
            {
                

                if (electrodomesticos[i] instanceof electrodomesticos){
                sumaElectrodomesticos += electrodomesticos[i].precioFinal();
            }
            if (electrodomesticos[i] instanceof Lavadora){
                sumaLavadoras += electrodomesticos[i].precioFinal();
            }
            if (electrodomesticos[i] instanceof television){
                sumaTelevisiones += electrodomesticos[i].precioFinal();
            }
        }
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

        Console.ReadKey();

        }
    }
}
