using LaYumba.Functional;
using static LaYumba.Functional.F;

// Enum.Parse<DayOfWeek>("Friday") -> Some(DayOfWeek.Friday)

namespace FPCSharp.Chapter_5;

public static class Exc2
{

    public static Option<T> Lookup<T>(this IEnumerable<T> collection, Func<T, bool> pred)
        => collection.Any(pred) ? Some(collection.First(pred)) : None;

    
    public static void Play()
    {
        Func<int,bool> pred = x => x < 0;
        
        var some = new List<int>() { 5, 10, -15, 20, 20, -25 }.Lookup<int>(pred);
        var none = new List<int>().Lookup<int>(pred);
        Console.WriteLine(some);
        Console.WriteLine(none);
    }
}