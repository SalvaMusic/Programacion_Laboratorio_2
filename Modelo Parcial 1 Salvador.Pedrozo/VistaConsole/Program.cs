using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace VistaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Genero un curso nuevo
            Curso cursoA = new Curso(2, Divisiones.A, new Profesor("Fede", "Dávila", "32124564", new
            DateTime(2015, 03, 20)));
            Curso cursoB = new Curso(2,Divisiones.B, new Profesor("Salva", "Pedrozo", "39708318", new
            DateTime(2017, 09, 28)));
            // Genero alumnos...
            Alumno a1 = new Alumno("Juan", "López", "22-3333-2", 2, Divisiones.A);
            Alumno a2 = new Alumno("José", "Martínez", "23-3343-6", 2, Divisiones.B);
            Alumno a3 = new Alumno("María", "Gutiérrez", "22-3333-2", 2, Divisiones.A);
            Alumno a4 = new Alumno("Marta", "Rodríguez", "23-3343-6", 2, Divisiones.A);
            Alumno a5 = new Alumno("Marta", "Rodríguez", "233343126", 2, Divisiones.A);
            // ... Y los agrego al curso
            cursoA += a1;
            cursoB += a2;
            cursoA += a3;
            cursoA += a4;
            cursoA += a5;
            // Imprimo los datos del curso
            Console.WriteLine((string)cursoA);
            Console.ReadKey();
            Console.WriteLine((string)cursoB);
            Console.ReadKey();
        }
    }
}
