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

        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
 
        public char getSexo()
        {
            return sexo;
        }

        public void setSexo(char sexo)
        {
            this.sexo = sexo;
        }

        public int getEdad()
        {
            return edad;
        }

        public void setEdad(int edad)
        {
            this.edad = edad;
        }

        public bool isAsistencia()
        {
            return asistencia;
        }

        public void setAsistencia(bool asistencia)
        {
            this.asistencia = asistencia;
        }

        public virtual void disponibilidad()
        {
            Random rnd = new Random();
        }

    }

    class Aula : Persona
    { 
        int maxEstudiantes = 30;
        private int id_aula;
        private Docente docente;
        private Estudiante[] estudiantes;
        private string materia;

        /*Constantes*/
        int MAX_ALUMNOS = 20;
        public static string[] MATERIAS={"Matematicas", "Filosofia", "Fisica"};

    //List<Estudiante> estudiante = new List<Estudiante>();
        public Aula()
        {
            id_aula = 1;
            docente = new Docente();
            estudiantes = new Estudiante[maxEstudiantes];
            creaAlumnos();
            materia = MATERIAS[r.Next(0, MATERIAS.Length)];

            //Docente docentes = new Docente("Profe Carlos");
            //Estudiante[] e = new Estudiante[maxEstudiantes];

        }
        private void creaAlumnos()
        {
            
            for (int i = 0; i < estudiantes.Length; i++)
            {
                estudiantes[i] = new Estudiante();
            }      

        }

        private bool asistenciaAlumnos()
        {

            int cuentaAsistencias = 0;

            //contamos las asistencias
            for (int i = 0; i < estudiantes.Length; i++)
            {

                if (estudiantes[i].isAsistencia())
                {
                    cuentaAsistencias++;
                }

            }

            //Muestro la asistencia total
            Console.WriteLine("Hay " + cuentaAsistencias + " alumnos");

            return cuentaAsistencias >= ((int)(estudiantes.Length / 2));

        }
        public bool darClase()
        {

            //Indicamos las condiciones para que se pueda dar la clase

            if (!docente.isAsistencia())
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

            for (int i = 0; i < estudiantes.Length; i++)
            {

                //Comprobamos si el alumno esta aprobado
                if (estudiantes[i].Nota() >= 5)
                {
                    //Segun el sexo, aumentara uno o otro
                    if (estudiantes[i].getSexo() == 'H')
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

        public Estudiante() : base()
        {
            nota = r.Next(0, 10);

            base.setEdad(r.Next(12, 15));
        }
        
        public int Nota()
        {
            return nota;
        }

        public override void disponibilidad()
        {
            if (r.Next(0, 100) < 50)
            {
                base.setAsistencia(false);
            }
            else
            {
                base.setAsistencia(true);
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
        public Docente() : base()
        {
        base.setEdad(r.Next(25, 50)); //llama al metodo padre

        materia = Aula.MATERIAS[r.Next(0, 2)];
        }
        public string getMateria()
        {
            return materia;
        }
        public void setMateria(string materia)
        {
            this.materia = materia;
        }


        public override void disponibilidad()
        {
            if (r.Next(0, 100) < 20)
            {
                base.setAsistencia(false);
            }
            else
            {
                base.setAsistencia(true);
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
