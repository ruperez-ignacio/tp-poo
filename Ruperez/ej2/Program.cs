using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej02
{
    class Persona
    {
        private string nombre;
        private int edad;
        private int DNI;
        public char sexo = 'H';
        private double peso;
        private double altura;
        public double vimc;
        public bool mayor;

        public Persona()
        {
        }
        public Persona(string nombre, int edad, char sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
        }
        public Persona(string nombre, int edad, char sexo, double peso, double altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.peso = peso;
            this.altura = altura;
        }
        public string calcularIMC()
        {
            vimc = peso / Math.Pow(altura, 2);
            if (vimc < 20)
            {
                vimc = -1;
                return "Esta en su peso ideal";

            }
            else if (vimc >= 20 && vimc <= 25)

            {
                vimc = 0;
                return "No esta en su peso ideal";
            }
            else
            {
                vimc = 1;
                return "Tiene sobre peso";
            }
        }
        public string esMayorDeEdad()
        {
            if (edad >= 18)
            {
                mayor = true;
                return "Es mayor de edad";
            }
            else
            {
                mayor = false;
                return "Es menor de edad";

            }
        }
        public void comprobarSexo()
        {
            if (sexo != 'M' || sexo != 'm')
            {
                sexo = 'H';
            }
            else
            {
                sexo = 'M';
            }
        }
        //public void generaDNI(int DNI)
        public void generaDNI()
        {
            Random myObject = new Random();
            myObject.Next(10000000, 100000000);
            Console.WriteLine(myObject.Next(10000000, 100000000));
        }

        //public string PesoIdeal()
        //{
        //    if (vimc == -1)
        //    {
        //        return "Esta en su peso ideal";
        //    }else if(vimc == 0)
        //    {
        //        return  "No esta en su peso ideal";

        //    }else 
        //    {
        //        return "Tiene sobre peso";

        //    }
        //}
        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }
        public int Edad
        {

            set
            {
                edad = value;
            }
            get
            {
                return edad;
            }
        }
        public char Sexo
        {
            set
            {
                sexo = value;
            }
            get
            {
                return sexo;
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
        public double Altura
        {
            set
            {
                altura = value;
            }
            get
            {
                return altura;
            }
        }

        class Program
        {


            static void Main(string[] args)
            {
                //Persona p1 = new Persona("Nacho", 17, 'H', 80, 1.70);

                Console.WriteLine("introduci nombre");
                string nombre = (Console.ReadLine());
                Console.WriteLine("introduci edad");
                int edad = int.Parse(Console.ReadLine());
                Console.WriteLine("introduci sexo");
                char sexo = char.Parse(Console.ReadLine());
                Console.WriteLine("introduci peso");
                double peso = double.Parse(Console.ReadLine());
                Console.WriteLine("introduci altura");
                double altura = double.Parse(Console.ReadLine());



                //Console.WriteLine("Nombre " + nombre);
                Persona objeto1 = new Persona(nombre, edad, sexo, peso, altura);
                Persona objeto3 = new Persona();

                objeto1.comprobarSexo();
                Console.WriteLine("objeto1:");
                Console.WriteLine(objeto1.esMayorDeEdad() + "   " + objeto1.calcularIMC());
                Console.WriteLine("Nombre: " + objeto1.Nombre + "  Edad: " + objeto1.Edad + "  Sexo: " + objeto1.Sexo + "  Peso: " + objeto1.Peso.ToString() + "  Altura: " + objeto1.Altura);


                Console.WriteLine("introduci nombre objeto2");
                string nombre1 = (Console.ReadLine());
                Console.WriteLine("introduci edad objeto2");
                int edad1 = int.Parse(Console.ReadLine());
                Console.WriteLine("introduci sexo objeto2");
                char sexo1 = char.Parse(Console.ReadLine());
                Console.WriteLine("introduci peso objeto2");


                Persona objeto2 = new Persona(nombre1, edad1, sexo1);

                objeto2.comprobarSexo();
                Console.WriteLine("objeto2:");
                Console.WriteLine(objeto2.esMayorDeEdad());
                Console.WriteLine("Nombre: " + objeto2.Nombre + "  Edad: " + objeto2.Edad + "  Sexo: " + objeto2.Sexo);







                //p1.calcularIMC();
                //Console.WriteLine(" IMC2 " + p1.vimc);
                //p1.generaDNI();
                //p1.esMayorDeEdad();
                //Console.WriteLine(" edad: " + p1.mayor);

                //myObject.generaDNI();
                //Console.WriteLine(aleatorio.numero);

                Console.ReadKey();
            }
        }
    }
}
