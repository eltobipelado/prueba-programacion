using ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Registro de PROVINCIAS y CIUDADES");
        List<Provincia> provincias = new List<Provincia>();

        Console.WriteLine("Ingrese el nombre de la provincia (o deje en blanco para pasar a pedir el nombre del gobernador)");
        string nombreprovincia = Console.ReadLine();

        while (!string.IsNullOrEmpty(nombreprovincia))
        {
            Provincia provincia = new Provincia();
            provincia.Nombre = nombreprovincia;

            Console.WriteLine("Ingrese el nombre del gobernador");
            provincia.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre de la region");
            provincia.Region = Console.ReadLine();


            Console.WriteLine("Ingrese el nombre de la ciudad (o deje en blanco para pasar a pedir la cantidad de habitantes)");
            string nombreciudad = Console.ReadLine();

            while (!string.IsNullOrEmpty(nombreciudad))
            {
                Ciudad ciudad = new Ciudad();
                ciudad.Nombre = nombreciudad;

                Console.WriteLine("Ingrese la cantidad de habitantes");
                ciudad.Cantidad_habitantes = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la superficie en kilometros");
                ciudad.Superficie = int.Parse(Console.ReadLine());

                
                Ciudad.Add(ciudad);
                Console.WriteLine("Ingrese el nombre de la ciudad");
                nombreciudad = Console.ReadLine();
            }
            provincias.Add(provincia);
            Console.WriteLine("Ingrese el nombre de la provincia");
            nombreprovincia = Console.ReadLine();

        }
        foreach (var Provincia in provincias)
        {
            Console.WriteLine($"Provincia");
            Console.WriteLine($"Nombre:  {Provincia.Nombre}");
            Console.WriteLine($"Gobernador: {Provincia.Gobernador}");
            Console.WriteLine($"Region: {Provincia.Region}");

            foreach (var Ciudad in ciudad)
            {
                Console.WriteLine($"Ciudades");
                Console.WriteLine($"Ciudad: {Ciudad.Nombre}");
            }

        }
    }
}
