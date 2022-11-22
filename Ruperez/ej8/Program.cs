using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej8
{
    public abstract class Persona
    {
        string nombre;
        int edad;
        char sexo;
        bool asistencia;
        int CHICO = 0;
        int CHICA = 1;
        string[] NOMBRES_CHICOS={"Pepe", "Fernando", "Alberto", "Nacho", "Eustaquio"}; 
        string[] NOMBRES_CHICAS={"Alicia", "Laura", "Clotilde", "Pepa", "Elena"}; 
        public static Random r = new Random();


        public Persona()
        {
            int determinar_sexo = r.Next(0, 1);

            //Si es 0 es un chico
            if (determinar_sexo == CHICO)
            {
                nombre = NOMBRES_CHICOS[r.Next(0, 4)];
                sexo = 'H';
            }
            else
            {
                nombre = NOMBRES_CHICAS[r.Next(0, 4)];
                sexo = 'M';
            }

            //Indicamos la disponibilidad
            disponibilidad();
        }

        public char getSexo()
        {
            return sexo;
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
        string[] materias = { "matemáticas", "filosofía", "física" };

        //Estudiante estudiante1;
        int maxEstudiantes = 30;
        public static string materia;
        public string Materia
        {
            get { return materia; }
            set { materia = value; }
        }

   

    //List<Estudiante> estudiante = new List<Estudiante>();



    public Aula()
        {
            id_aula = 1;
            Docente docente = new Docente();
            Estudiante[] Estudiantes = new Estudiante[maxEstudiantes];
            creaAlumnos();
            materia = materias[r.Next(0, materias.Length)];

            //Docente docentes = new Docente("Profe Carlos");
            //Estudiante[] e = new Estudiante[maxEstudiantes];

        }
        private void creaAlumnos()
        {

            for (int i = 0; i < Estudiantes.Length; i++)
            {
                Estudiantes[i] = new Estudiante();
            }      

        }

        private bool asistenciaAlumnos()
        {

            int cuentaAsistencias = 0;

            //contamos las asistencias
            for (int i = 0; i < Estudiantes.Length; i++)
            {

                if (Estudiantes[i].Asistencia)
                {
                    cuentaAsistencias++;
                }

            }

            //Muestro la asistencia total
            Console.WriteLine("Hay " + cuentaAsistencias + " alumnos");

            return cuentaAsistencias >= (Estudiantes.Length / 2);

        }
        public bool darClase()
        {

            //Indicamos las condiciones para que se pueda dar la clase

            if (!docente.Asistencia)
            {
                Console.WriteLine("El profesor no esta, no se puede dar clase");
                return false;
            }
            else if (!docente.getMateria().Equals(materia))
            {
                Console.WriteLine("La materia del profesor y del aula no es la misma, no se puede dar clase");
                return false;
            }
            else if (!asistenciaAlumnos())
            {
                Console.WriteLine("La asistencia no es suficiente, no se puede dar clase");
                return false;
            }

            Console.WriteLine("Se puede dar clase");
            return true;

        }

        public void notas()
        {
            int chicosApro = 0;
            int chicasApro = 0;

            for (int i = 0; i < Estudiantes.Length; i++)
            {

                //Comprobamos si el alumno esta aprobado
                if (Estudiantes[i].Nota() >= 5)
                {
                    //Segun el sexo, aumentara uno o otro
                    if (Estudiantes[i].getSexo() == 'H')
                    {
                        chicosApro++;
                    }
                    else
                    {
                        chicasApro++;
                    }


                }

            }

            Console.WriteLine("Hay " + chicosApro + " chicos y " + chicasApro + " chicas aprobados/as");

        }
    
    }
    class Estudiante : Persona
    {
        int calificacion;
        int nota;

        public Estudiante()
        {
            nota = r.Next(0, 10);

            Edad = r.Next(12, 15);
        }
        
        public int Nota()
        {
            return nota;
        }

        public override void disponibilidad()
        {
            if (r.Next(0, 100) < 50)
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
            int calificacion = r.Next(0, 10);
        }

    }

    class Docente : Persona
    {
        string materia;
        public string getMateria()
        {
            return materia;
        }
        public Docente()
        {

        }
        

        public override void disponibilidad()
        {
            if (r.Next(0, 100) < 20)
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
            Aula aula = new Aula();

            //Indicamos si se puede dar la clase
            if (aula.darClase())
            {
                aula.notas();
            }

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
