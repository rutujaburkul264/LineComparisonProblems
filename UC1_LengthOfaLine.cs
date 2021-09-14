using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparisonproblems
{
    class UC1_LengthOfaLine
    {
        public static void LengthOfALine()
        {
            Console.WriteLine("Enter x1 & y1 co-ordinates");
            var x1 = Convert.ToDouble(Console.ReadLine());
            var y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter x2 & y2 co-ordinates");
            var x2 = Convert.ToDouble(Console.ReadLine());
            var y2 = Convert.ToDouble(Console.ReadLine());

            Double LengthOfaLine = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Length of a line is : " + LengthOfaLine);
        }
    }
}
