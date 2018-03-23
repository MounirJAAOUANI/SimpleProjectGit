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
    }
}
