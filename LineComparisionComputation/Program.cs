using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Define the two points
            double x1 = 1;
            double y1 = 2;
            double x2 = 4;
            double y2 = 6;

            //Calculate the length of the line
            double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            //Print the length to the console
            Console.WriteLine("The length of the line is :" +length);
            Console.ReadLine();
        }
    }
}
