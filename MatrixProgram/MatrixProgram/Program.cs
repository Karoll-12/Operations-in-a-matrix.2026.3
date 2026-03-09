using System;
using MatrizOO;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese orden de la matriz: ");
        int n = int.Parse(Console.ReadLine()!);

        SquareMatrix matrix = new SquareMatrix(n);

        matrix.FillMatrix();

        Console.WriteLine("\nMatriz generada:\n");
        matrix.ShowMatrix();

        Console.WriteLine("\nLa sumatoria es: " + matrix.SumMatrix());
        Console.WriteLine("El valor máximo es: " + matrix.MaxValue());
        Console.WriteLine("El valor mínimo es: " + matrix.MinValue());
    }
}