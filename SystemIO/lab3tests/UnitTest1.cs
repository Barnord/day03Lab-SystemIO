using System;
using Xunit;
using SystemIOChallenges;

namespace lab3tests
{
    public class UnitTest1
    {
        [Fact]
        public void BiggestNumInArrayTrue()
        {
            int[] arr = { 14, 23, 86, 4 };
            int whatever = Program.Challenge5(arr);
            Assert.Equal(86, whatever);
        }

        [Fact]
        public void ZeroIndexTrue()
        {
            int[] arr = { 55, 23, 19, 4 };
            int whatever = Program.Challenge5(arr);
            Assert.Equal(55, whatever);
        }
    }
}
