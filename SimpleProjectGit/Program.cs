using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProjectGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            Console.WriteLine("Enter the height of the Rectangle : ");
            rectangle.Height = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the wifth of the Rectangle : ");
            rectangle.Width = double.Parse(Console.ReadLine());

            Console.WriteLine("The surface of the rectangle is : " + rectangle.Surface());
            Console.WriteLine("The perimeter of the rectangle is : " + rectangle.Perimeter());
            Console.WriteLine(rectangle.GenerateResult(1,100));
            Console.ReadKey();
        }
    }
}
