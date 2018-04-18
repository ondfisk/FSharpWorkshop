using Xunit;
using static FSharpWorkshop.FunctionalCSharp.PatternMatching;

namespace FSharpWorkshop.FunctionalCSharp.Tests
{
    public class PatternMatchingTests
    {
        [Fact(DisplayName = "DiceSumFunctional numbers")]
        public void DiceSum5_given_numbers_returns_sum()
        {
            var numbers = new object[] { 1, 2, 3, 4, 5, 6, 1, 2, 3, 4, 5, 6 };

            var sum = DiceSumFunctional(numbers);

            Assert.Equal(42, sum);
        }

        [Fact(DisplayName = "DiceSumFunctional numbers and subLists")]
        public void DiceSum5_given_numbers_and_subLists_returns_sum()
        {
            var numbers = new object[] { 1, 2, new object[] { 3, 4, 5 }, 6, 1, new object[] { 2, 3, 4 }, 5, 6 };

            var sum = DiceSumFunctional(numbers);

            Assert.Equal(42, sum);
        }

        [Fact(DisplayName = "DiceSumFunctional numbers and subLists with subSubLists")]
        public void DiceSum5_given_numbers_and_subLists_and_subSubLists_returns_sum()
        {
            var numbers = new object[] { 1, 2, new object[] { 3, 4, 5, new object[] { 1, 2, 3, 4, 5, 6 } }, 6 };

            var sum = DiceSumFunctional(numbers);

            Assert.Equal(42, sum);
        }
    }
}
