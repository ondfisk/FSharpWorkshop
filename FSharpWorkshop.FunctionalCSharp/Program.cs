using System;
using System.Collections.Concurrent;
using System.Linq;

namespace FSharpWorkshop.FunctionalCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string foo = default;
            var sw = new ConcurrentQueue<string>();
            sw.Enqueue("foo");
            Console.WriteLine(sw.ToList());
        }
    }
}
