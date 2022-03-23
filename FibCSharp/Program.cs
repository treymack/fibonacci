using System;
using System.Collections.Generic;
using System.Linq;

namespace FibCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var max = 50_000_000;
            Enumerable.Range(0, int.MaxValue)
                .Select(Fib)
                .TakeWhile(x => x <= max)
                .ForEach(Console.WriteLine);
        }

        static int Fib(int arg) =>
            arg switch
            {
                < 0 => throw new Exception("Argument must be >= 0"),
                0 => 0,
                1 => 1,
                _ => Fib(arg - 2) + Fib(arg - 1),
            };
    }

    public static class IEnumerableExt
    {
        public static void ForEach<T>(this IEnumerable<T> xs, Action<T> act)
        {
            foreach (var x in xs)
            {
                act(x);
            }
        }
    }
}
