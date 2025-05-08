
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    private static int maxsuperficieprovincia;

    static void Main(string[]args)
    {
        Console.WriteLine("Registro de PROVINCIAS y CIUDADES");
        List<Provincia> provincias = new List<Provincia>();

        Console.WriteLine("Ingrese el nombre de la provincia (o deje en blanco para terminar):");
        string nombreprovincia = Console.ReadLine();

        while (!string.IsNullOrEmpty(nombreprovincia))
        {
            Provincia provincia = new Provincia();
            provincia.Nombre = nombreprovincia;

            Console.WriteLine("Ingrese el nombre del gobernador:");
            provincia.Gobernador = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre de la región:");
            provincia.Region = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre de la ciudad (o deje en blanco para terminar):");
            string nombreciudad = Console.ReadLine();

            while (!string.IsNullOrEmpty(nombreciudad))
            {
                Ciudad ciudad = new Ciudad();
                ciudad.Nombre = nombreciudad;

                Console.WriteLine("Ingrese la cantidad de habitantes:");
                ciudad.Cantidad_habitantes = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la superficie en km²:");
                ciudad.Superficie = int.Parse(Console.ReadLine());

                provincia.Ciudades.Add(ciudad);

                Console.WriteLine("Ingrese el nombre de la ciudad (o deje en blanco para terminar):");
                nombreciudad = Console.ReadLine();
            }

            provincias.Add(provincia);
            Console.WriteLine("Ingrese el nombre de la provincia (o deje en blanco para terminar):");
            nombreprovincia = Console.ReadLine();
        }

       
        foreach (var provincia in provincias)
        {
            Console.WriteLine("Provincia");
            Console.WriteLine($"Nombre: {provincia.Nombre}");
            Console.WriteLine($"Gobernador: {provincia.Gobernador}");
            Console.WriteLine($"Región: {provincia.Region}");
            Console.WriteLine("--------------");
            Console.WriteLine("Ciudades:");
            foreach (var ciudad in provincia.Ciudades)
            {
                Console.WriteLine($"Ciudad: {ciudad.Nombre}");
                Console.WriteLine($"Habitantes: {ciudad.Cantidad_habitantes}");
                Console.WriteLine($"Superficie: {ciudad.Superficie} km²");
                Console.WriteLine("--------------");
            }
        }

        
        Ciudad ciudadmaspoblada = null;
        Ciudad ciudadmayorsuperficie = null;
        Provincia provinciamaspoblada = null;
        Provincia provinciamayorsuperficie = null;

        int maxhabitantesprovincia = 0;
        int maxSuperficieProvincia = 0;

        foreach (var provincia in provincias)
        {
            int totalhabitantes = provincia.Ciudades.Sum(c => c.Cantidad_habitantes);
            int totalsuperficie = provincia.Ciudades.Sum(c => c.Superficie);

            if (totalhabitantes > maxhabitantesprovincia)
            {
                maxhabitantesprovincia = totalhabitantes;
                provinciamaspoblada = provincia;
            }

            if (totalsuperficie > maxsuperficieprovincia)
            {
                maxsuperficieprovincia = totalsuperficie;
                provinciamayorsuperficie = provincia;
            }

            foreach (var ciudad in provincia.Ciudades)
            {
                if (ciudadmaspoblada == null || ciudad.Cantidad_habitantes > ciudadmaspoblada.Cantidad_habitantes)
                    ciudadmaspoblada = ciudad;

                if (ciudadmayorsuperficie == null || ciudad.Superficie > ciudadmayorsuperficie.Superficie)
                    ciudadmayorsuperficie = ciudad;
            }
        }

        Console.WriteLine("Resumen estadistico");
        Console.WriteLine($"Ciudad mas poblada: {ciudadmaspoblada.Nombre} ({ciudadmaspoblada.Cantidad_habitantes} habitantes)");
        Console.WriteLine($"Ciudad con mayor superficie: {ciudadmayorsuperficie.Nombre} ({ciudadmayorsuperficie.Superficie} km²)");
        Console.WriteLine($"Provincia mas poblada: {provinciamaspoblada.Nombre} ({maxhabitantesprovincia} habitantes)");
        Console.WriteLine($"Provincia con mayor superficie: {provinciamayorsuperficie.Nombre} ({maxSuperficieProvincia} km²)");
    }
}


