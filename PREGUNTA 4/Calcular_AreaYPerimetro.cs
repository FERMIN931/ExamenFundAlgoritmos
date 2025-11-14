using System;

class Program
{
    static void Main()
    {
        int opcion;
        do
        {
            opcion = MostrarMenu();
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese el lado del cuadrado:");
                    double lado = Convert.ToDouble(Console.ReadLine());
                    var (areaCuadrado, perimetroCuadrado) = Cuadrado(lado);
                    Console.WriteLine($"Área: {areaCuadrado:F2} Perímetro: {perimetroCuadrado:F2}");
                    break;

                case 2:
                    Console.WriteLine("Ingrese la base del rectángulo:");
                    double baseR = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura del rectángulo:");
                    double altura = Convert.ToDouble(Console.ReadLine());
                    var (areaRectangulo, perimetroRectangulo) = Rectangulo(baseR, altura);
                    Console.WriteLine($"Área: {areaRectangulo:F2} Perímetro: {perimetroRectangulo:F2}");
                    break;

                case 3:
                    Console.WriteLine("Ingrese el radio del círculo:");
                    double radio = Convert.ToDouble(Console.ReadLine());
                    var (areaCirculo, perimetroCirculo) = Circulo(radio);
                    Console.WriteLine($"Área: {areaCirculo:F2} Perímetro: {perimetroCirculo:F2}");
                    break;

                case 4:
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        } while (opcion != 4);
    }

    static (double, double) Cuadrado(double lado)
    {
        double area = lado * lado;
        double perimetro = 4 * lado;
        return (area, perimetro);
    }

    static (double, double) Rectangulo(double baseR, double altura)
    {
        double area = baseR * altura;
        double perimetro = 2 * (baseR + altura);
        return (area, perimetro);
    }

    static (double, double) Circulo(double radio)
    {
        double area = Math.PI * radio * radio;
        double perimetro = 2 * Math.PI * radio;
        return (area, perimetro);
    }

    static int MostrarMenu()
    {
        Console.WriteLine("Elija una figura:");
        Console.WriteLine("1. Cuadrado");
        Console.WriteLine("2. Rectángulo");
        Console.WriteLine("3. Círculo");
        Console.WriteLine("4. Salir");
        int opcion = Convert.ToInt32(Console.ReadLine());
        return opcion;
    }
}