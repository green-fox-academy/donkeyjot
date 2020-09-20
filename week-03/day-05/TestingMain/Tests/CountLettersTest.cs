using System;
using System.Collections.Generic;
using TestingMain;
using Xunit;

namespace Tests
{
    public class CountLettersTest
    {
        [Fact]
        public void TestCountMethod()
        {
            CountLetters countLetters = new CountLetters("Holle");
            Dictionary<string, int> test = new Dictionary<string, int>()            //does the order of keyvalue pairs in dict matter?...seems not...
            {
                { "H", 1 },
                { "e", 1 },
                {"l", 2 },
                {"o", 1 }
            };
            for (int i = 0; i < test.Count; i++)
            {
                Assert.Equal(test, countLetters.LettersCount());
            }

        }
    }
}
