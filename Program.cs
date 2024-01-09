using System;

namespace RownaniaKwadratowe
{ 
class Program
{
    static void Main()
    {
        Console.WriteLine("Program rozwiązujący równania kwadratowe (Ax^2 + Bx + C = 0)");

        Console.Write("Podaj parametr A: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj parametr B: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj parametr C: ");
        double c = Convert.ToDouble(Console.ReadLine());

        SolveQuadraticEquation(a, b, c);

        Console.WriteLine("Koniec programu.");
    }

    static void SolveQuadraticEquation(double a, double b, double c)
    {
        double delta = b * b - 4 * a * c;

        if (delta > 0)
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"Równanie ma dwa pierwiastki rzeczywiste: x1 = {x1}, x2 = {x2}");
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"Równanie ma jeden pierwiastek rzeczywisty: x = {x}");
        }
        else
        {
            Console.WriteLine("Równanie nie ma pierwiastków rzeczywistych.");
        }
    }
}
}
