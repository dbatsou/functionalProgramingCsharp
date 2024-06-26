using LaYumba.Functional;
using static LaYumba.Functional.F;
using static System.Console;
 
// Enum.Parse<DayOfWeek>("Friday") -> Some(DayOfWeek.Friday)

namespace FPCSharp.Chapter_5;

public static class Enum
{
    public static Option<DayOfWeek> Parse(string day)
        => System.Enum.TryParse(day, out DayOfWeek result)
            ? Some(result)
            : None;


    public static void Play()
    {
        Write("Tell me day: ");
        var day = Console.ReadLine();

        var result = Parse(day);
        WriteLine(result);
    }
}