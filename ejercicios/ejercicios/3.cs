using System;

public class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public char Genero { get; set; }
    public string Telefono { get; set; }

    // Constructor
    public Persona(string nombre, int edad, char genero, string telefono)
    {
        Nombre = nombre;
        Edad = edad;
        Genero = genero;
        Telefono = telefono;
    }

    // Método para editar información
    public void EditarInformacion(string nombre, int edad, char genero, string telefono)
    {
        Nombre = nombre;
        Edad = edad;
        Genero = genero;
        Telefono = telefono;
    }

    // Método para imprimir detalles
    public void ImprimirDetalles()
    {
        Console.WriteLine($"\n--- DETALLES DE LA PERSONA ---");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Edad: {Edad} años");
        Console.WriteLine($"Género: {Genero}");
        Console.WriteLine($"Teléfono: {Telefono}");
    }

    // Método para calcular edad en días
    public void CalcularEdadEnDias()
    {
        int edadDias = Edad * 365;
        Console.WriteLine($"\nLa edad de {Nombre} en días es: {edadDias} días");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("--- AGENDA DE PERSONAS ---");

        Console.Write("Ingrese el nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese la edad: ");
        int edad = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el género (F/M): ");
        char genero = char.Parse(Console.ReadLine().ToUpper());

        Console.Write("Ingrese el teléfono: ");
        string telefono = Console.ReadLine();

        // Crear objeto Persona
        Persona persona = new Persona(nombre, edad, genero, telefono);

        bool salir = false;
        while (!salir)
        {
            Console.WriteLine("\n--- MENÚ DE OPCIONES ---");
            Console.WriteLine("1. Imprimir detalles de la persona");
            Console.WriteLine("2. Calcular edad en días");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    persona.ImprimirDetalles();
                    break;
                case 2:
                    persona.CalcularEdadEnDias();
                    break;
                case 3:
                    salir = true;
                    Console.WriteLine("¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    break;
            }
        }
    }
}