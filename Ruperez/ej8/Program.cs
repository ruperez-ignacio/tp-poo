using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej8
{
    class Persona
    {
        string nombre;
        int edad;
        char sexo;
        bool asistencia;
        int faltas;
        int prob;
        int sitio;

        public Persona()
        {

        }
        public Persona(string nombre)
        {
            this.nombre = nombre;
        }
        public int Sitio
        {
            get { return sitio; }
            set { sitio = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public bool Asistencia
        {
            get { return asistencia; }
            set { asistencia = value; }
        }
        public int Faltas
        {
            get { return faltas; }
            set { faltas = value; }
        }
        public int Prob
        {
            get { return prob; }
            set { prob = value; }
        }
        public virtual void disponibilidad()
        {
            Random rnd = new Random();
        }

    }

    class Aula : Persona
    {
        int id_aula;
        Docente docente;
        Estudiante[] Estudiantes;

        Estudiante estudiante1;
        int maxEstudiantes = 30;
        string[] materia = { "matemáticas", "filosofía", "física" };
        Estudiante estudiante2 = new Estudiante();



        //List<Estudiante> estudiante = new List<Estudiante>();



        public Aula()
        {
            Docente docentes = new Docente("Profe Carlos");

            Estudiante[] e = new Estudiante[maxEstudiantes];
       
        }

        private bool AsistenciaEst()
        {
            int t = 0;

            foreach (var estudiante in estudiantes)
            {
                if (estudiante.Asistio == true)
                {
                    t++;
                }
            }

            if (t > Estudiantes.Length / 2)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

    }

    class Estudiante : Persona
    {
        int calificacion;

        public Estudiante()
        {

        }
        public Estudiante(string nombre) : base(nombre)
        {
            this.Nombre = nombre;
        }

        public override void disponibilidad()
        {
            Random rnd = new Random();
            if (rnd.Next(0, 100) < 50)
            {
                Asistencia = false;
            }
            else
            {
                Asistencia = true;
            }
        }

        public void asistencia()
        {
            Random rnd = new Random();
            int calificacion = rnd.Next(0, 10);
        }

    }

    class Docente : Persona
    {
        string materia;

        public Docente()
        {

        }
        public Docente(string nombre) : base(nombre)
        {
            this.Nombre = nombre;
        }

        public override void disponibilidad()
        {
            Random rnd = new Random();
            if (rnd.Next(0, 100) < 20)
            {
                Asistencia = false;
            }
            else
            {
                Asistencia = true;
            }
        }

    }
    


    internal class Program
    {
        static void Main(string[] args)
        {
            if ()
            {

            }
            
            Aula aula = new Aula();

            //Estudiante est;
            //List<Estudiante> list = new List<Estudiante>();


            //est = new Estudiante();
            //list.Add(est);
            //est = new Estudiante();
            //list.Add(est);
            //est = new Estudiante();
            //list.Add(est);
            //est = new Estudiante();
            //list.Add(est);
            //list.Add(docentes);
            //Aula aula = new Aula();
            

            /* if (Docente == true)
             est1.disponibilidad();
             est2.disponibilidad();
             */
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
