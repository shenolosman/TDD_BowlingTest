using System;
using Xunit;

namespace Lekstuga
{
    public class UnitTest1
    {
        [Fact]
        public void MinArrayTest()
        {
            //arrange
            //s�tt upp en situation



            bool test = false;
            int[] arr = new int[4];


            //act
            //s�tt upp en situation
            arr[0] = 3;


            //assert
            //analysera resultatet
            Assert.True(true, "3");
        }

        [Fact]
        public void DefaultArrayValueZeroTest()
        {
            //arrange
            //s�tt upp en situation


            int[] arr = new int[4];


            //act
            //donothing


            //assert
            //analysera resultatet
            Assert.Equal(0, arr[0]);
        }
    }
}
