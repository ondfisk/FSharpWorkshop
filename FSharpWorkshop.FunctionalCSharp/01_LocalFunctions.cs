using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FSharpWorkshop.FunctionalCSharp
{
    public class Iterator
    {
        public static IEnumerable<char> AlphabetSubset(char start, char end)
        {
            if (start < 'a' || start > 'z')
            {
                throw new ArgumentOutOfRangeException(paramName: nameof(start), message: "start must be a letter");
            }
            if (end < 'a' || end > 'z')
            {
                throw new ArgumentOutOfRangeException(paramName: nameof(end), message: "end must be a letter");
            }
            if (end <= start)
            {
                throw new ArgumentException($"{nameof(end)} must be greater than {nameof(start)}");
            }
            for (var c = start; c < end; c++)
            {
                yield return c;
            }
        }

        #region AlphabetSubset2
        public static IEnumerable<char> AlphabetSubset2(char start, char end)
        {
            if (start < 'a' || start > 'z')
                throw new ArgumentOutOfRangeException(paramName: nameof(start), message: "start must be a letter");
            if (end < 'a' || end > 'z')
                throw new ArgumentOutOfRangeException(paramName: nameof(end), message: "end must be a letter");

            if (end <= start)
                throw new ArgumentException($"{nameof(end)} must be greater than {nameof(start)}");
            return AlphabetSubsetImplementation(start, end);
        }

        private static IEnumerable<char> AlphabetSubsetImplementation(char start, char end)
        {
            for (var c = start; c < end; c++)
            {
                yield return c;
            }
        }
        #endregion
        #region AlphabetSubset3
        public static IEnumerable<char> AlphabetSubset3(char start, char end)
        {
            if (start < 'a' || start > 'z')
            {
                throw new ArgumentOutOfRangeException(paramName: nameof(start), message: "start must be a letter");
            }
            if (end < 'a' || end > 'z')
            {
                throw new ArgumentOutOfRangeException(paramName: nameof(end), message: "end must be a letter");
            }
            if (end <= start)
            {
                throw new ArgumentException($"{nameof(end)} must be greater than {nameof(start)}");
            }
            return alphabetSubsetImplementation();

            IEnumerable<char> alphabetSubsetImplementation()
            {
                for (var c = start; c < end; c++)
                {
                    yield return c;
                }
            }
        }
        #endregion

        #region PerformLongRunningWork
        public Task<string> PerformLongRunningWork(string address, int index, string name)
        {
            if (string.IsNullOrWhiteSpace(address))
            {
                throw new ArgumentException(message: "An address is required", paramName: nameof(address));
            }
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException(paramName: nameof(index), message: "The index must be non-negative");
            }
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException(message: "You must supply a name", paramName: nameof(name));
            }

            return longRunningWorkImplementation();

            async Task<string> longRunningWorkImplementation()
            {
                var interimResult = await FirstWork(address);
                var secondResult = await SecondStep(index, name);
                return $"The results are {interimResult} and {secondResult}. Enjoy.";
            }
        }
        async Task<string> FirstWork(string address) => await Task.FromResult(address);
        async Task<string> SecondStep(int index, string name) => await Task.FromResult(index + name);
        #endregion
    }

    public static class Program2
    {
        public static void Main2(string[] args)
        {
            var resultSet = Iterator.AlphabetSubset('f', 'a');
            Console.WriteLine("iterator created");
            Console.WriteLine(string.Join(", ", resultSet));
        }
    }
}
