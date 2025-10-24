using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios
{
    internal class _8
    {
        static void Main()
        {
            Console.Write("Ingrese el número de empleados: ");
            int numEmpleados = int.Parse(Console.ReadLine());

            int[] empleadosPorMes = new int[12];
            double[] bonosPorMes = new double[12];
            string[] nombresMeses = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
                                "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};

            int totalEmpleadosBonificacion = 0;
            int sumaEdades = 0;
            double totalBonificacion = 0;

            for (int i = 0; i < numEmpleados; i++)
            {
                Console.WriteLine($"\n--- EMPLEADO {i + 1} ---");
                Console.Write("Ingrese la fecha de nacimiento (dd/mm/aaaa): ");
                DateTime fechaNacimiento = DateTime.Parse(Console.ReadLine());

                int edad = DateTime.Now.Year - fechaNacimiento.Year;
                if (DateTime.Now.DayOfYear < fechaNacimiento.DayOfYear)
                    edad--;

                sumaEdades += edad;

                // Verificar si aplica para bonificación
                if (edad > 18 && edad < 50)
                {
                    totalEmpleadosBonificacion++;
                    int mesCumpleaños = fechaNacimiento.Month - 1; // Array index 0-based
                    empleadosPorMes[mesCumpleaños]++;
                    bonosPorMes[mesCumpleaños] += 150000;
                    totalBonificacion += 150000;
                }
            }

            // Resultados
            double promedioEdades = (double)sumaEdades / numEmpleados;

            Console.WriteLine("\n--- RESULTADOS TIK TOK ---");
            Console.WriteLine($"Promedio de edades: {promedioEdades:F1} años");
            Console.WriteLine($"Total empleados con bonificación: {totalEmpleadosBonificacion}");
            Console.WriteLine($"Total a pagar en bonificaciones: ${totalBonificacion:F2}");

            Console.WriteLine("\n--- DESGLOSE POR MESES ---");
            Console.WriteLine("| Mes           | Empleados TikTok | Dinero en Bonos |");
            Console.WriteLine("|---------------|------------------|-----------------|");

            for (int i = 0; i < 12; i++)
            {
                if (empleadosPorMes[i] > 0)
                {
                    Console.WriteLine($"| {nombresMeses[i],-13} | {empleadosPorMes[i],-16} | ${bonosPorMes[i],-14:F2} |");
                }
            }
        }
    }
}
