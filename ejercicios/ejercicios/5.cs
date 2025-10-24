using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios
{
    internal class _5
    {
        static void Main()
        {
            Dictionary<string, int> creditosPrograma = new Dictionary<string, int>
        {
            {"Ingeniería de sistemas", 20},
            {"Psicología", 16},
            {"Economía", 18},
            {"Comunicación Social", 18},
            {"Administración de Empresas", 20}
        };

            Dictionary<string, double> descuentos = new Dictionary<string, double>
        {
            {"Ingeniería de sistemas", 0.18},
            {"Psicología", 0.12},
            {"Economía", 0.10},
            {"Comunicación Social", 0.05},
            {"Administración de Empresas", 0.15}
        };

            Dictionary<string, int> estudiantesPorPrograma = new Dictionary<string, int>
        {
            {"Ingeniería de sistemas", 0},
            {"Psicología", 0},
            {"Economía", 0},
            {"Comunicación Social", 0},
            {"Administración de Empresas", 0}
        };

            double valorCredito = 200000;
            int totalCreditos = 0;
            double totalSinDescuento = 0;
            double totalDescuentos = 0;
            double totalNeto = 0;

            Console.Write("Ingrese el número de estudiantes a matricular: ");
            int numEstudiantes = int.Parse(Console.ReadLine());

            for (int i = 0; i < numEstudiantes; i++)
            {
                Console.WriteLine($"\n--- ESTUDIANTE {i + 1} ---");
                Console.WriteLine("Programas disponibles:");
                Console.WriteLine("1. Ingeniería de sistemas");
                Console.WriteLine("2. Psicología");
                Console.WriteLine("3. Economía");
                Console.WriteLine("4. Comunicación Social");
                Console.WriteLine("5. Administración de Empresas");

                Console.Write("Seleccione el programa (1-5): ");
                int opcionPrograma = int.Parse(Console.ReadLine());

                string programa = "";
                switch (opcionPrograma)
                {
                    case 1: programa = "Ingeniería de sistemas"; break;
                    case 2: programa = "Psicología"; break;
                    case 3: programa = "Economía"; break;
                    case 4: programa = "Comunicación Social"; break;
                    case 5: programa = "Administración de Empresas"; break;
                    default: programa = "Ingeniería de sistemas"; break;
                }

                Console.Write("Forma de pago (1: Efectivo, 2: En línea): ");
                int formaPago = int.Parse(Console.ReadLine());

                int creditos = creditosPrograma[programa];
                double valorSinDescuento = creditos * valorCredito;
                double descuento = (formaPago == 1) ? valorSinDescuento * descuentos[programa] : 0;
                double valorNeto = valorSinDescuento - descuento;

                // Actualizar estadísticas
                estudiantesPorPrograma[programa]++;
                totalCreditos += creditos;
                totalSinDescuento += valorSinDescuento;
                totalDescuentos += descuento;
                totalNeto += valorNeto;

                Console.WriteLine($"Valor a pagar: ${valorNeto:F2}");
            }

            // Mostrar resultados finales
            Console.WriteLine("\n--- RESULTADOS FINALES ---");
            Console.WriteLine("\na. Estudiantes por programa:");
            foreach (var programa in estudiantesPorPrograma)
            {
                Console.WriteLine($"   {programa.Key}: {programa.Value} estudiantes");
            }

            Console.WriteLine($"\nb. Total créditos inscritos: {totalCreditos}");
            Console.WriteLine($"c. Valor total sin descuento: ${totalSinDescuento:F2}");
            Console.WriteLine($"d. Total descuentos aplicados: ${totalDescuentos:F2}");
            Console.WriteLine($"e. Valor neto de inscripciones: ${totalNeto:F2}");
        }
    }
}
