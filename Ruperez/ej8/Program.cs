﻿using System;
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

        public void asistencias()
        {
            


            if (this is Estudiante)
            {

            }
        } 
    }

    class Aula
    {

    }

    class Estudiante : Persona
    {
        int calificacion;

        public void asistencias()
        {
            
            //if()
            //{

            //}
        }
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
