using System;
using System.Collections.Generic;
using System.Text;

namespace FSharpWorkshop.FunctionalCSharp
{
    public class Tuples
    {
        static void Main3(string[] args)
        {
            var letters = ("a", "b");

            (string Alpha, string Beta) namedLetters = ("a", "b");

            var alphabetStart = (Alpha: "a", Beta: "b");

            (string First, string Second) firstLetters = (Alpha: "a", Beta: "b");

            var (f, s) = firstLetters;


            // Not immutable
            namedLetters.Alpha = "alfa";
            namedLetters.Beta = "bravo";
        }

        private static (int Max, int Min) Range(IEnumerable<int> numbers)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            foreach (var n in numbers)
            {
                min = (n < min) ? n : min;
                max = (n > max) ? n : max;
            }
            return (max, min);
        }

        static void Main4(string[] args)
        {
            IEnumerable<int> numbers = default;

            var range = Range(numbers);

            (int max, int min) = Range(numbers);

            var (ma, mi) = Range(numbers);  
        }

        public class Point
        {
            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }

            public double X { get; }
            public double Y { get; }

            public void Deconstruct(out double x, out double y)
            {
                x = X;
                y = Y;
            }
        }

        static void Main5(string[] args)
        {
            var p = new Point(3.14, 2.71);

            (double X, double Y) = p;

            var (horizontalDistance, verticalDistance) = p;
        }
    }
}
