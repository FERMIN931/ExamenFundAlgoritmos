using System;

class Program
{
    static void Main()
    {
        string nombre, estado;
        double nota1, nota2, nota3, promedio;

        while (true)
        {
            Console.WriteLine("Ingrese el nombre del estudiante (o FIN para terminar):");
            nombre = Console.ReadLine();

            if (nombre.ToUpper() == "FIN")
            {
                break;
            }

            Console.WriteLine("Ingrese la primera nota del estudiante:");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la segunda nota del estudiante:");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la tercera nota del estudiante:");
            nota3 = Convert.ToDouble(Console.ReadLine());

            promedio = (nota1 + nota2 + nota3) / 3;

            if (promedio >= 15)
            {
                estado = "Aprobado";
            }
            else if (promedio >= 11)
            {
                estado = "Recuperación";
            }
            else
            {
                estado = "Desaprobado";
            }

            Console.WriteLine($"Hola {nombre}, tu estado es: {estado}");
        }
    }
}