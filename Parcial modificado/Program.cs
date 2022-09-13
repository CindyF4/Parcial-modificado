using System;
using System.Collections;

namespace Parcial_modificado
{
    class Program
    {
        static void Main(string[] args)
        {
            int Roses;
            do
            {
                int numberStudents;
                ArrayList registro = new ArrayList();
                string nombre;
                int edad;
                double nota1;
                double nota2;
                double parcial;
                double promedio;

                int contador = 0;

                Console.WriteLine("Ingrese el numero de estudiantes a evaluar: ");
                numberStudents = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                while (contador < numberStudents)
                {
                    Console.Write("Ingrese el nombre del estudiante: ");
                    nombre = Console.ReadLine();
                    Console.Write("Ingrese la edad del estudiante: ");
                    edad = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese la nota de Laboratorio 1: ");
                    nota1 = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese la nota de Laboratorio 2: ");
                    nota2 = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese la nota parcial: ");
                    parcial = int.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    promedio = (nota1 * .3) + (nota2 * .3) + (parcial * .4);

                    Console.WriteLine("El promedio total del alumno es: {0}", promedio);

                    if (promedio >= 6)
                    {
                        Console.WriteLine("ALUMNO APROBADO");

                    }
                    else
                    {
                        Console.WriteLine("ALUMNO REPROBADO");
                    }




                    Students students = new Students(nombre, edad, nota1, nota2, parcial, promedio );
                    registro.Add(students);

                    contador++;
                }


                Console.WriteLine(" --- RESULTADOS --- ");
                foreach (Students st in registro)
                {
                    Console.WriteLine(st.getData());
                }

                Console.WriteLine("¿Quiere finalizar el proceso? Escriba el numero 5");
                Roses = Convert.ToInt32(Console.ReadLine());

            } while (Roses != 5);
            Console.WriteLine("Finalizo el proceso");
        }



    }




    
    
    
}
