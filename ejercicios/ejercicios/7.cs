using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios
{
    internal class _7
    {
        static void Main()
        {
            Console.Write("Ingrese el número de conductores: ");
            int numConductores = int.Parse(Console.ReadLine());

            int menores30 = 0;
            int masculinos = 0;
            int femeninos = 0;
            int masculinos12a30 = 0;
            int registradosFuera = 0;

            int añoActual = DateTime.Now.Year;

            for (int i = 0; i < numConductores; i++)
            {
                Console.WriteLine($"\n--- CONDUCTOR {i + 1} ---");
                Console.Write("Año de nacimiento: ");
                int añoNacimiento = int.Parse(Console.ReadLine());

                Console.Write("Sexo (1: Femenino, 2: Masculino): ");
                int sexo = int.Parse(Console.ReadLine());

                Console.Write("Registro del carro (1: Bogotá, 2: Otras ciudades): ");
                int registro = int.Parse(Console.ReadLine());

                int edad = añoActual - añoNacimiento;

                // Estadísticas
                if (edad < 30) menores30++;

                if (sexo == 1) femeninos++;
                else if (sexo == 2) masculinos++;

                if (sexo == 2 && edad >= 12 && edad <= 30) masculinos12a30++;

                if (registro == 2) registradosFuera++;
            }

            // Cálculo de porcentajes
            double porcMenores30 = (double)menores30 / numConductores * 100;
            double porcMasculinos = (double)masculinos / numConductores * 100;
            double porcFemeninos = (double)femeninos / numConductores * 100;
            double porcMasculinos12a30 = (double)masculinos12a30 / numConductores * 100;
            double porcRegistradosFuera = (double)registradosFuera / numConductores * 100;

            Console.WriteLine("\n--- ESTADÍSTICAS DE ACCIDENTES ---");
            Console.WriteLine($"Porcentaje de conductores menores de 30 años: {porcMenores30:F2}%");
            Console.WriteLine($"Porcentaje de conductores masculinos: {porcMasculinos:F2}%");
            Console.WriteLine($"Porcentaje de conductores femeninos: {porcFemeninos:F2}%");
            Console.WriteLine($"Porcentaje de conductores masculinos entre 12-30 años: {porcMasculinos12a30:F2}%");
            Console.WriteLine($"Porcentaje de conductores con carros fuera de Bogotá: {porcRegistradosFuera:F2}%");
        }
    }
}
