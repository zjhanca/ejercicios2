using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios
{
    internal class _9
    {
        static void Main()
        {
            Random random = new Random();
            int camionesCargados = 0;
            const int MAX_CAMIONES = 20;

            Console.WriteLine("--- SISTEMA DE CARGA DE CAMIONES ---");

            while (camionesCargados < MAX_CAMIONES)
            {
                Console.WriteLine($"\n--- CAMIÓN {camionesCargados + 1} ---");
                Console.Write("Ingrese la capacidad del camión (18000-28000 litros): ");
                int capacidadCamion = int.Parse(Console.ReadLine());

                int cargaActual = 0;
                bool camionCompleto = false;

                while (!camionCompleto && camionesCargados < MAX_CAMIONES)
                {
                    // Generar tanque aleatorio entre 3000 y 9000 litros
                    int tanque = random.Next(3000, 9001);

                    Console.WriteLine($"\nPróximo tanque: {tanque} litros");
                    Console.WriteLine($"Carga actual: {cargaActual} litros");
                    Console.WriteLine($"Capacidad disponible: {capacidadCamion - cargaActual} litros");

                    if (cargaActual + tanque <= capacidadCamion)
                    {
                        cargaActual += tanque;
                        Console.WriteLine($"✅ Tanque cargado. Nueva carga: {cargaActual} litros");

                        if (cargaActual == capacidadCamion)
                        {
                            Console.WriteLine("🎯 Camión cargado al máximo!");
                            camionCompleto = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("❌ El tanque excede la capacidad. Despachando camión...");
                        camionCompleto = true;
                    }

                    if (!camionCompleto)
                    {
                        Console.Write("¿Continuar cargando? (s/n): ");
                        string respuesta = Console.ReadLine().ToLower();
                        if (respuesta != "s")
                        {
                            camionCompleto = true;
                        }
                    }
                }

                Console.WriteLine($"🚚 Camión {camionesCargados + 1} despachado con {cargaActual} litros");
                camionesCargados++;

                if (camionesCargados < MAX_CAMIONES)
                {
                    Console.WriteLine($"\nPreparando próximo camión... ({MAX_CAMIONES - camionesCargados} restantes)");
                }
            }

            Console.WriteLine("\n🎉 ¡Jornada completada! 20 camiones cargados y despachados.");
        }
    }
}
