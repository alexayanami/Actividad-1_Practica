using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int cantidadPersonas = 0;

        while (true)
        {
            Console.Write("Ingrese la cantidad de personas: ");
            if (int.TryParse(Console.ReadLine(), out cantidadPersonas) && cantidadPersonas >= 1)
            {
                break;
            }
            Console.WriteLine("Valor inválido. Debe ser un número mayor o igual a 1.\n");
        }

        List<string> nombres = new List<string>();
        List<int> edades = new List<int>();

        for (int i = 0; i < cantidadPersonas; i++)
        {
            Console.WriteLine("\nPersona " + (i + 1));

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            int edad;
            while (true)
            {
                Console.Write("Edad: ");
                if (int.TryParse(Console.ReadLine(), out edad) && edad >= 0)
                {
                    break;
                }
                Console.WriteLine("Edad inválida. Intente nuevamente.");
            }

            nombres.Add(nombre);
            edades.Add(edad);
        }

        if (cantidadPersonas == 1)
        {
            Console.WriteLine("\n--- Resultado ---");
            Console.WriteLine("Nombre: " + nombres[0]);

            if (edades[0] >= 18)
                Console.WriteLine("Es mayor de edad.");
            else
                Console.WriteLine("Es menor de edad.");
        }
        else
        {
            Console.WriteLine("\n--- Lista General ---");
            for (int i = 0; i < nombres.Count; i++)
            {
                Console.WriteLine(nombres[i] + " - " + edades[i] + " años");
            }

            List<string> mayores = new List<string>();
            List<string> menores = new List<string>();

            for (int i = 0; i < nombres.Count; i++)
            {
                if (edades[i] >= 18)
                    mayores.Add(nombres[i] + " - " + edades[i] + " años");
                else
                    menores.Add(nombres[i] + " - " + edades[i] + " años");
            }

            if (mayores.Count > 0)
            {
                Console.WriteLine("\n--- Mayores de Edad ---");
                foreach (var persona in mayores)
                    Console.WriteLine(persona);
            }

            if (menores.Count > 0)
            {
                Console.WriteLine("\n--- Menores de Edad ---");
                foreach (var persona in menores)
                    Console.WriteLine(persona);
            }
        }

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}