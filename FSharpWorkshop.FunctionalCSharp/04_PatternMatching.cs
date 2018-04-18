using System;
using System.Collections.Generic;
using System.Linq;

namespace FSharpWorkshop.FunctionalCSharp
{
    public class PatternMatching
    {
        public static int DiceSum(IEnumerable<int> values)
        {
            return values.Sum();
        }

        public static int DiceSum2(IEnumerable<object> values)
        {
            var sum = 0;
            foreach (var item in values)
            {
                if (item is int val)
                {
                    sum += val;
                }
                else if (item is IEnumerable<object> subList)
                {
                    sum += DiceSum2(subList);
                }
            }
            return sum;
        }

        public static int DiceSum3(IEnumerable<object> values)
        {
            var sum = 0;
            foreach (var item in values)
            {
                switch (item)
                {
                    case int val:
                        sum += val;
                        break;
                    case IEnumerable<object> subList:
                        sum += DiceSum3(subList);
                        break;
                }
            }
            return sum;
        }

        public static int DiceSum4(IEnumerable<object> values)
        {
            var sum = 0;
            foreach (var item in values)
            {
                switch (item)
                {
                    case 0:
                        break;
                    case int val:
                        sum += val;
                        break;
                    case IEnumerable<object> subList when subList.Any():
                        sum += DiceSum4(subList);
                        break;
                    case IEnumerable<object> subList:
                        break;
                    case null:
                        break;
                    default:
                        throw new InvalidOperationException("unknown item type");
                }
            }
            return sum;
        }

        public static int DiceSumFunctional(IEnumerable<object> values)
        {
            int flatten(object v)
            {
                switch (v)
                {
                    case int val:
                        return val;
                    case IEnumerable<object> subList:
                        return DiceSumFunctional(subList);
                    default:
                        throw new InvalidOperationException("unknown item type");
                }
            }
            return values.Select(flatten).Sum();
        }

        public struct PercentileDice
        {
            public int OnesDigit { get; }
            public int TensDigit { get; }

            public PercentileDice(int tensDigit, int onesDigit)
            {
                OnesDigit = onesDigit;
                TensDigit = tensDigit;
            }
        }

        public static int DiceSum5(IEnumerable<object> values)
        {
            var sum = 0;
            foreach (var item in values)
            {
                switch (item)
                {
                    case 0:
                        break;
                    case int val:
                        sum += val;
                        break;
                    case PercentileDice dice:
                        sum += dice.TensDigit + dice.OnesDigit;
                        break;
                    case IEnumerable<object> subList when subList.Any():
                        sum += DiceSum5(subList);
                        break;
                    case IEnumerable<object> subList:
                        break;
                    case null:
                        break;
                    default:
                        throw new InvalidOperationException("unknown item type");
                }
            }
            return sum;
        }
    }
}
