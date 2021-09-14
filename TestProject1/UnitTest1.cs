using ClassLibrary1;
using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        int? length;
        [Fact]
        public void StringTest()
        {
            //arrange
            Class1 obj = new Class1();
           
            string[] strings ={"Hello", "World"};

            //act
            length = obj.StringLength(strings);

            //assert
            Assert.Equal(5+5,length);
        }

        [Fact]
        public void EmpyStringTest()
        {
            Class1 obj = new Class1();
            string[] strings = {};

            length = obj.StringLength(strings);

            Assert.Equal(0,length);
        }

        [Fact]
        public void NullArrayTest()
        {
            Class1 obj = new Class1();
            string[] strings = null;

            length = obj.StringLength(strings);
            Assert.Null(length);
           // Assert.Equal(0,length);
            //Assert.Throws<NullReferenceException>(() =>
            //{
            //    obj.StringLength(strings);
            //});
        }

        //[Fact]
        //public void StringNullArrayTest()
        //{
        //    Class1 obj = new Class1();
        //    string[] strings = {"Hello", null, "World"};

        //    length = obj.StringLength(strings);

        //    Assert.Equal(0,length);
        //}
    }

    public class UnitTest2
    {
         int lenght;
        [Fact]
        public void NullIntTest()
        {
            Class1 obj = new Class1();
            int[] numbersInts = {5 , 10};

            lenght = obj.GetSum(numbersInts);

            Assert.Equal(15,lenght);
        }
    }
}



    //[Fact]
    //public void MinArrayTest()
    //{
    //    //arrange
    //    //sätt upp en situation



    //    bool test = false;
    //    int[] arr = new int[4];


    //    //act
    //    //sätt upp en situation
    //    arr[0] = 3;


    //    //assert
    //    //analysera resultatet
    //    Assert.True(true, "3");
    //}

    //[Fact]
    //public void DefaultArrayValueZeroTest()
    //{
    //    //arrange
    //    //sätt upp en situation


    //    int[] arr = new int[4];


    //    //act
    //    //donothing


    //    //assert
    //    //analysera resultatet
    //    Assert.Equal(0, arr[0]);
    //}

