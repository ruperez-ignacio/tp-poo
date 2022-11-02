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
        
    }
    


    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
