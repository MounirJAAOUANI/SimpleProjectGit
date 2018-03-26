using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SimpleProject.Tests
{
    public class RectangleTests
    {
        [Fact]
        public void SurfaceTest()
        {
            Rectangle rectangle = new Rectangle() { Height = 25, Width = 11 };
            double surface = rectangle.Surface();
            Assert.Equal(275, surface);
        }

        [Fact]
        public void PerimeterTest()
        {
            Rectangle rectangle = new Rectangle() { Height = 25, Width = 11 };
            double perimeter = rectangle.Perimeter();
            Assert.Equal(72, perimeter);
        }

        [Fact]
        public void Return1ifInput1Test()
        {
            Rectangle rectangle = new Rectangle();
            Assert.Equal("1", rectangle.GenerateResult(1, 1));
        }

        [Fact]
        public void Return2ifInput2Test()
        {
            Rectangle rectangle = new Rectangle();
            Assert.Equal("2", rectangle.GenerateResult(2, 2));
        }

        [Fact]
        public void ReturnFizzifInput3Test()
        {
            Rectangle rectangle = new Rectangle();
            Assert.Equal("Fizz", rectangle.GenerateResult(3, 3));
        }

        [Fact]
        public void ReturnFizzifInput4Test()
        {
            Rectangle rectangle = new Rectangle();
            Assert.Equal("4", rectangle.GenerateResult(4, 4));
        }

        [Fact]
        public void ReturnBuzzifInput5Test()
        {
            Rectangle rectangle = new Rectangle();
            Assert.Equal("Buzz", rectangle.GenerateResult(5, 5));
        }


        [Fact]
        public void ReturnFizzifInput6Test()
        {
            Rectangle rectangle = new Rectangle();
            Assert.Equal("Fizz", rectangle.GenerateResult(6, 6));
        }

        [Fact]
        public void ReturnBuzzifInput10Test()
        {
            Rectangle rectangle = new Rectangle();
            Assert.Equal("Buzz", rectangle.GenerateResult(10, 10));
        }

        [Fact]
        public void ReturnFizzBuzzifInput15Test()
        {
            Rectangle rectangle = new Rectangle();
            Assert.Equal("FizzBuzz", rectangle.GenerateResult(15, 15));
        }

        [Fact]
        public void Return12ifInput12Test()
        {
            Rectangle rectangle = new Rectangle();
            Assert.Equal("12", rectangle.GenerateResult(1, 2));
        }


        [Fact]
        public void Return12Fizz4ifInput1to4Test()
        {
            Rectangle rectangle = new Rectangle();
            Assert.Equal("12Fizz4", rectangle.GenerateResult(1, 4));
        }


    }
}
