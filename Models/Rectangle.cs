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

        public string GenerateResult(int minNumber, int maxNumber)
        {
            return ReturnCorrectString(minNumber, maxNumber);
        }

        private string ReturnCorrectString(int minNumber, int maxNumber)
        {
            string result = string.Empty;

            for (int i = minNumber; i <= maxNumber; i++)
            {
                if (i % 15 == 0)
                    result += "FizzBuzz";
                else if (i % 3 == 0)
                    result += "Fizz";
                else if (i % 5 == 0)
                    result += "Buzz";
                else result += i.ToString();
            }

            return result;
        }
    }
}
