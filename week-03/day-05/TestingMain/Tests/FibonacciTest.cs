using System;
using TestingMain;
using Xunit;

namespace Tests
{
    public class FibonacciTest
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(4, 3)]
        public void TestingFib(int i, int expected)
        {
           
            Assert.Equal(expected, new Fibonacci().FibonacciByIndex(i));
        }
    }
}
