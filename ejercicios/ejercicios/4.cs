using System;
using System.Collections.Generic;

public class Libro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string Editorial { get; set; }
    public int AnioPublicacion { get; set; }

    public Libro(string titulo, string autor, string editorial, int anioPublicacion)
    {
        Titulo = titulo;
        Autor = autor;
        Editorial = editorial;
        AnioPublicacion = anioPublicacion;
    }
}

public class Biblioteca
{
    private List<Libro> libros = new List<Libro>();

    public void AgregarLibro(Libro libro)
    {
        libros.Add(libro);
        Console.WriteLine($"Libro '{libro.Titulo}' agregado correctamente.");
    }

    public void ListarLibros()
    {
        if (libros.Count == 0)
        {
            Console.WriteLine("No hay libros en la biblioteca.");
            return;
        }

        Console.WriteLine("\n--- LISTA DE LIBROS ---");
        for (int i = 0; i < libros.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {libros[i].Titulo} - {libros[i].Autor} ({libros[i].AnioPublicacion})");
        }
    }

    public void BuscarLibro(string titulo)
    {
        if (string.IsNullOrWhiteSpace(titulo))
        {
            Console.WriteLine("Ingrese un título válido para buscar.");
            return;
        }

        string termino = titulo.Trim();
        var librosEncontrados = libros.FindAll(l =>
            !string.IsNullOrEmpty(l.Titulo) &&
            l.Titulo.IndexOf(termino, StringComparison.OrdinalIgnoreCase) >= 0);

        if (librosEncontrados.Count == 0)
        {
            Console.WriteLine($"No se encontraron libros con el título: {titulo}");
            return;
        }

        Console.WriteLine($"\n--- LIBROS ENCONTRADOS CON '{titulo}' ---");
        foreach (var libro in librosEncontrados)
        {
            Console.WriteLine($"- {libro.Titulo} | {libro.Autor} | {libro.Editorial} | {libro.AnioPublicacion}");
        }
    }
}

// Elimine o renombre esta clase Program si ya existe otra definición en otro archivo.
// Por ejemplo, puede renombrar la clase a ProgramBiblioteca para evitar el conflicto:

class ProgramBiblioteca
{
    static void Main()
    {
        Biblioteca biblioteca = new Biblioteca();
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("\n--- SISTEMA DE BIBLIOTECA ---");
            Console.WriteLine("1. Agregar libro");
            Console.WriteLine("2. Listar libros");
            Console.WriteLine("3. Buscar libro por título");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            string opcionInput = Console.ReadLine();
            if (!int.TryParse(opcionInput, out int opcion))
            {
                Console.WriteLine("Opción no válida. Intente de nuevo.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    string titulo;
                    do
                    {
                        Console.Write("Título: ");
                        titulo = Console.ReadLine()?.Trim();
                        if (string.IsNullOrEmpty(titulo)) Console.WriteLine("El título no puede estar vacío.");
                    } while (string.IsNullOrEmpty(titulo));

                    string autor;
                    do
                    {
                        Console.Write("Autor: ");
                        autor = Console.ReadLine()?.Trim();
                        if (string.IsNullOrEmpty(autor)) Console.WriteLine("El autor no puede estar vacío.");
                    } while (string.IsNullOrEmpty(autor));

                    Console.Write("Editorial: ");
                    string editorial = Console.ReadLine()?.Trim() ?? string.Empty;

                    int anio;
                    while (true)
                    {
                        Console.Write("Año de publicación: ");
                        string anioInput = Console.ReadLine();
                        if (int.TryParse(anioInput, out anio)) break;
                        Console.WriteLine("Año no válido. Intente de nuevo.");
                    }

                    Libro nuevoLibro = new Libro(titulo, autor, editorial, anio);
                    biblioteca.AgregarLibro(nuevoLibro);
                    break;

                case 2:
                    biblioteca.ListarLibros();
                    break;

                case 3:
                    Console.Write("Ingrese el título a buscar: ");
                    string tituloBuscar = Console.ReadLine();
                    biblioteca.BuscarLibro(tituloBuscar);
                    break;

                case 4:
                    salir = true;
                    Console.WriteLine("¡Hasta luego!");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}