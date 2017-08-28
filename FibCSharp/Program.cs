using System;
using System.Linq;

namespace FibCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var max = 50;
            Enumerable.Range(0, int.MaxValue)
                .Select(Fib)
                .TakeWhile(x => x <= max)
                .ToList()
                .ForEach(Console.WriteLine);
        }

        static int Fib(int arg) =>
            arg < 0 ? throw new Exception("Argument must be >= 0")
            : arg == 0 ? 0
            : arg == 1 ? 1
            : Fib(arg - 2) + Fib(arg - 1);
    }
}
