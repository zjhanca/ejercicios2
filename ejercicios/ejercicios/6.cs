using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios
{
    internal class _6
    {
        static void Main()
        {
            Console.Write("Ingrese el número de empleados: ");
            int numEmpleados = int.Parse(Console.ReadLine());

            double pagoBasico = 500000;
            double totalBonificaciones = 0;

            for (int i = 0; i < numEmpleados; i++)
            {
                Console.WriteLine($"\n--- EMPLEADO {i + 1} ---");
                Console.Write("Ingrese el número de ventas realizadas: ");
                int numVentas = int.Parse(Console.ReadLine());

                int ventasCat1 = 0, ventasCat2 = 0, ventasCat3 = 0;
                double totalVentas = 0;
                double bonificacionEmpleado = 0;

                for (int j = 0; j < numVentas; j++)
                {
                    Console.Write($"Ingrese el valor de la venta {j + 1}: $");
                    double venta = double.Parse(Console.ReadLine());

                    // Categorizar ventas
                    if (venta <= 300000)
                        ventasCat1++;
                    else if (venta > 300000 && venta < 800000)
                        ventasCat2++;
                    else
                        ventasCat3++;

                    totalVentas += venta;

                    // Calcular bonificación
                    if (venta >= 400000 && venta <= 800000)
                        bonificacionEmpleado += venta * 0.03;
                    else if (venta > 800000)
                        bonificacionEmpleado += venta * 0.10;
                }

                totalBonificaciones += bonificacionEmpleado;
                double totalPagar = pagoBasico + bonificacionEmpleado;

                Console.WriteLine($"\n--- RESUMEN EMPLEADO {i + 1} ---");
                Console.WriteLine($"Ventas <= $300,000: {ventasCat1}");
                Console.WriteLine($"Ventas > $300,000 y < $800,000: {ventasCat2}");
                Console.WriteLine($"Ventas >= $800,000: {ventasCat3}");
                Console.WriteLine($"Total ventas: ${totalVentas:F2}");
                Console.WriteLine($"Pago básico: ${pagoBasico:F2}");
                Console.WriteLine($"Bonificación: ${bonificacionEmpleado:F2}");
                Console.WriteLine($"Total a pagar: ${totalPagar:F2}");
            }

            Console.WriteLine($"\n--- TOTAL BONIFICACIONES PAGADAS: ${totalBonificaciones:F2} ---");
        }
    }
}
