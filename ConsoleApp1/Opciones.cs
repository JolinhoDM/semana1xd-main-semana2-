using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Opciones
    {
        public static ListaAlumnos cabezon = null;
        public static Random random = new Random();

        public static void registrate()
        {
            ListaAlumnos nuevo = new ListaAlumnos();
            Console.WriteLine($"\n Ingresa tus nombres y apellidos: ");
            nuevo.Nombres = Console.ReadLine();

            Console.WriteLine($"\nIngresa tu edad: ");
            nuevo.edad = int.Parse(Console.ReadLine());
                nuevo.Codigo = "N" + random.Next(1000, 10000) + "P";


                for (int i = 0; i < 2; i++)
             {
                Console.WriteLine($"\nNombre del curso {i + 1}: ");
                nuevo.notas[i, 0] = Console.ReadLine(); 

                int valor1 = -1;
                while (valor1 < 0 || valor1 > 20)
                {
                    Console.Write("Nota 1 (0-20): ");
                    string entrada = Console.ReadLine();
                    valor1 = int.Parse(entrada);

                    if (valor1 >= 0 && valor1 <= 20)
                    {
                        nuevo.notas[i, 1] = entrada;
                    }
                    else
                    {
                        Console.WriteLine("¡Error! La nota debe estar entre 0 y 20.");
                    }
                }

                int valor2 = -1;
                while (valor2 < 0 || valor2 > 20)
                {
                    Console.Write("Nota 2 (0-20): ");
                    string entrada = Console.ReadLine();
                    valor2 = int.Parse(entrada);

                    if (valor2 >= 0 && valor2 <= 20)
                    {
                        nuevo.notas[i, 2] = entrada;
                    }
                    else
                    {
                        Console.WriteLine("¡Error! La nota debe estar entre 0 y 20.");
                    }
                }
            }

                if (cabezon == null)
                {
                    cabezon = nuevo;
                }
                else
                {
                    ListaAlumnos temp = cabezon;
                    while (temp.siguiente != null)
                    {
                        temp = temp.siguiente;
                    }
                    temp.siguiente = nuevo;
                }
                Console.WriteLine("Alumno registrado con exito!!");
          
          
        }
        public static void Mostrar()
        {
            ListaAlumnos temp = cabezon;
            while(temp != null)
            {
                Console.WriteLine($"  Codigo:              {temp.Codigo}" );
                Console.WriteLine($"  Nombres y Apellidos: {temp.Nombres}");
                Console.WriteLine($"  Edad:                {temp.edad}");
                Console.WriteLine($"  Correo:              {temp.Codigo}@upn.pe ");
                Console.WriteLine();
                Console.WriteLine("Cursos               Nota 1        Nota 2");
                for(int i = 0; i < 2; i++)
                {
                    Console.WriteLine($"{temp.notas[i, 0],-20}\t{temp.notas[i,1],-8}\t{temp.notas[i,2],-8}");
                }
                temp = temp.siguiente;
            }
        }
        public static void ContarAlumno()
        {
            int contador = 0;
            ListaAlumnos temp = cabezon;
            while (temp != null)
            {
                contador++;
                temp = temp.siguiente;
            }
            Console.WriteLine(" Total de alumnos registrados:" + contador);
            Console.WriteLine();
        }
        public static void Buscar( )
        {
           
        }
           
    }
}
