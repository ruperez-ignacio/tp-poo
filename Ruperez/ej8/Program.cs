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
        

        public string Nombre { get; set; }
        public int Edad { get; set; }
        public char Sexo { get; set; }
        public bool Asistencia
        {
            get { return asistencia; }
            set { asistencia = value; }
        }

        public void disponibilidad()
        {
            Random rnd = new Random();
            int prob = rnd.Next(0, 100 + 1);


            if (prob < 50)
            {
                Asistencia = false;
            }
            else
            {
                Asistencia = true;
            }

        }

    }

    class Aula
    {

    }

    class Estudiante : Persona
    {
        int calificacion;

        
    }

    class Docente : Persona
    {
        string[] materia = { "matemáticas", "filosofía", "física" };

        public void dispDocente()
        {
            Random rnd = new Random();
            int prob = rnd.Next(0, 100 + 1);

            if (prob < 20)
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
        }
    }
}
