// See https://aka.ms/new-console-template for more information

using static System.Double;

namespace FPCSharp.Chapter3;

public class Chapter3
{
    void ImpurPure()
    {
        var height = Read("height");
        var kg = Read("kg");

        var bmi = CalcBmi(kg, height);

        Write(bmi);
    }

    double Read(string prop)
    {
        Console.Write($"{prop}:");
        TryParse(Console.ReadLine(), out double result);
        return result;
    }

    void Write(double bmi) => Console.WriteLine(BmiTitles(bmi));
    static string BmiTitles(double d) => d < 18.5 ? ("underweight") : d >= 25 ? ("overweight") : ("healthy");
    static double CalcBmi(double kg, double height) => kg / Math.Pow(height, 2);
}