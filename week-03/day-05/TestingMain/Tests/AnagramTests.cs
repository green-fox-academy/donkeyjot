using System;
using TestingMain;
using Xunit;

namespace Tests
{
    public class AnagramTests
    {
        [Theory]
        [InlineData(false, "asdasdasdf", "sgggshfgh")]
        [InlineData(true, "I am Lord Voldemort", "Tom Marvolo Riddle")]
        [InlineData(true, "silent", "Listen")]
        public void ReallyAnAnagram(bool expected, string a, string b)
        {
            AnagramClass anagram = new AnagramClass();
            Assert.Equal(expected, anagram.IsAnagram(a, b));
        }
    }
}
