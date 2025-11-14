using System;

class Program
{
    static void Main()
    {
        int N;
        double precio, subtotal = 0, IGV, total;

        // Leer la cantidad de productos
        Console.WriteLine("Ingrese el número de productos:");
        N = int.Parse(Console.ReadLine());

        // Calcular el subtotal
        for (int i = 1; i <= N; i++)
        {
            Console.WriteLine($"Ingrese el precio del producto {i}:");
            precio = double.Parse(Console.ReadLine());
            subtotal += precio;
        }

        // Calcular IGV y total
        IGV = subtotal * 0.18;
        total = subtotal + IGV;

        // Mostrar resultados
        Console.WriteLine($"Subtotal: {subtotal}");
        Console.WriteLine($"IGV (18%): {IGV}");
        Console.WriteLine($"Total a pagar: {total}");
    }
}