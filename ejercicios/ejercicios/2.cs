using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios
{
    internal class _2
    {
        static void Main()
        {
            Console.Write("Ingrese el salario del empleado: ");
            double salario = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el valor de ahorro mensual programado: ");
            double ahorro = double.Parse(Console.ReadLine());

            double eps = salario * 0.125; // 12.5%
            double pension = salario * 0.16; // 16%
            double totalDeducir = eps + pension + ahorro;
            double totalRecibir = salario - totalDeducir;

            Console.WriteLine("\n--- COLLILA DE PAGO ---");
            Console.WriteLine($"Salario del empleado: ${salario:F2}");
            Console.WriteLine($"Ahorro mensual programado: ${ahorro:F2}");
            Console.WriteLine($"Deducción EPS (12.5%): ${eps:F2}");
            Console.WriteLine($"Deducción Pensión (16%): ${pension:F2}");
            Console.WriteLine($"Total a recibir: ${totalRecibir:F2}");
        }
    }
}
