using System;
using System.Collections.Generic;
using TestingMain;
using Xunit;

namespace Tests
{
    public class SumTests
    {

        //Apparently one cannot put List type into InlineData...

        //[Theory]
        ////[InlineData(new List<int>())]
        //[InlineData(List<int> mylist = new List<int>() { 4, 5, 5, 6 })]
        //public void TestingSum(List mylist)
        //{
        //    var sum = new Sum();

        //    Assert.Equal(20, sum.Summa(mylist));

        //}

        [Fact]
        public void TestingSum()
        {
            var sum = new Sum();
            List<int> mylist = new List<int>() { 4, 5, 5, 6 };

            Assert.Equal(20, sum.Summa(mylist));

        }

        [Fact]
        public void TestingSumEmpty()
        {
            var sum = new Sum();
            List<int> mylist = new List<int>();

            Assert.Equal(0, sum.Summa(mylist));

        }

        [Fact]
        public void TestingSumOne()
        {
            var sum = new Sum();
            List<int> mylist = new List<int>() { 5 };

            Assert.Equal(5, sum.Summa(mylist));

        }

        [Fact]
        public void TestingNull()
        {
            var sum = new Sum();
            List<int> mylist = new List<int>();
            mylist = null;

            Assert.Equal(0, sum.Summa(mylist));

        }


    }
}
