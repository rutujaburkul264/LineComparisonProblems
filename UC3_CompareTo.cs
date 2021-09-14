using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparisonproblems
{
    class UC3_CompareTo
    {
        public static void CompareToLength()
        {
            Console.WriteLine("Enter x1 & y1 co-ordinates");
            var x1 = Convert.ToDouble(Console.ReadLine());
            var y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter x2 & y2 co-ordinates");
            var x2 = Convert.ToDouble(Console.ReadLine());
            var y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter m1 & n1 co-ordinates");
            var m1 = Convert.ToInt32(Console.ReadLine());
            var n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter m2 & n2 co-ordinates");
            var m2 = Convert.ToInt32(Console.ReadLine());
            var n2 = Convert.ToInt32(Console.ReadLine());

            Double LengthOfaLine1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Length of a line is : " + LengthOfaLine1);

            Double LengthOfaLine2 = Math.Sqrt(Math.Pow((m2 - m1), 2) + Math.Pow((n2 - n1), 2));
            Console.WriteLine("Length of a line is : " + LengthOfaLine2);

            if (LengthOfaLine1.CompareTo(LengthOfaLine2) == 0)
                Console.WriteLine("Both lengths have same value.");
            else
                Console.WriteLine("Both lengths have different value");
        }
    }
}
