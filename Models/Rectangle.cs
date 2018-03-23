using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Rectangle
    {
        public double Height { get; set; }
        public double Width { get; set; }


        public Rectangle()
        {
            Height = 0;
            Width = 0;
        }

        public double Surface()
        {
            return Height * Width;
        }

        public double Perimeter()
        {
            return (Height + Width) * 2;
        }

    }
}
