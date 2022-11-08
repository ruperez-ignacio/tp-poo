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
        

        public string Nombre { get; set; }
        public int Edad { get; set; }
        public char Sexo { get; set; }
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

        public virtual void disponibilidad()
        {
            Random rnd = new Random();
            int prob = rnd.Next(0, 100 + 1);

            if(this is Estudiante)
            {
                if (prob < 50)
                {
                    Asistencia = false;
                    faltas++;
                }
                else
                {
                    Asistencia = true;
                }
            }
            if (this is Docente)
            {
                if (prob < 20)
                {
                    Asistencia = false;
                    faltas++;
                }
                else
                {
                    Asistencia = true;
                }
            }
        }

    }

    class Aula 
    {
        int id_aula; 
        int maxEstudiantes = 30;
        string[] materia = { "matemáticas", "filosofía", "física" };

        public override void disponibilidad()
        {
        }
    }

    class Estudiante : Persona
    {
        int calificacion;
        
    }

    class Docente : Persona
    {

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
