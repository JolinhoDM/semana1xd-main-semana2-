using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opciones;
            Console.Clear();
            do
            {
                Console.WriteLine($"\n");
                Console.WriteLine(" Menú de opciones   ");
                Console.WriteLine(" 1.registrar alumnos");
                Console.WriteLine(" 2.mostrar lista de alumnos ");
                Console.WriteLine(" 3.alumnos registrados");
                Console.WriteLine(" 4.Buscar alumno ");
                Console.WriteLine(" 5.Ordenar lista de alumnos   ");
                Console.WriteLine("     4.salir   ");
                
                opciones = int.Parse(Console.ReadLine());
                switch (opciones)
                {
                    case 1:
                        Opciones.registrate();
                        break;
                    case 2:
                        Opciones.Mostrar();
                        break;
                    case 3:
                        Opciones.ContarAlumno();
                        break;
                    case 4:
                        Opciones.BuscarAlumno();
                        break;
                    case 5:Opciones.OrdenarAlumno();
                        break;
                }
            } while (opciones != 4);
        }
    }
}
