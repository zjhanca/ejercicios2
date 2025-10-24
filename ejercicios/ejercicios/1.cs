using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el monto del préstamo: ");
            double monto = double.Parse(Console.ReadLine());

            double tasaInteres = 0.05; // 5% anual
            double interesAnual = monto * tasaInteres;
            double interesTrimestral = interesAnual / 4;
            double interesMensual = interesAnual / 12;
            double totalPagar = monto + (interesAnual * 5); // 5 años

            Console.WriteLine("\n--- RESULTADOS DEL PRÉSTAMO ---");
            Console.WriteLine($"Intereses pagados en un año: ${interesAnual:F2}");
            Console.WriteLine($"Intereses pagados en el tercer trimestre: ${interesTrimestral:F2}");
            Console.WriteLine($"Intereses pagados en el primer mes: ${interesMensual:F2}");
            Console.WriteLine($"Total a pagar en 5 años: ${totalPagar:F2}");
        }
    }
}
