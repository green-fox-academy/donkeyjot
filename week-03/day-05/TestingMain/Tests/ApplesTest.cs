using System;
using Xunit;
using TestingMain;

namespace Tests
{
    public class ApplesTest
    {
        [Fact]
        public void TestingApples()
        {
            var apples = new Apples();

            Assert.Equal("apple", apples.GetApple());

        }

    }

    
}
