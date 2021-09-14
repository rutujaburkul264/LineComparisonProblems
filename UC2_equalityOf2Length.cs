using System;

namespace LineComparisonproblems
{
    class UC2_equalityOf2Length
    {
        public static void Equality()
        {
            Console.WriteLine("Enter x1 & y1 co-ordinates");
            var x1 = Convert.ToInt32(Console.ReadLine());
            var y1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter x2 & y2 co-ordinates");
            var x2 = Convert.ToInt32(Console.ReadLine());
            var y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a1 & b1 co-ordinates");
            var a1 = Convert.ToInt32(Console.ReadLine());
            var b1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a2 & b2 co-ordinates");
            var a2 = Convert.ToInt32(Console.ReadLine());
            var b2 = Convert.ToInt32(Console.ReadLine());

            Double LengthOfaLine1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Length of a line is : " + LengthOfaLine1);

            Double LengthOfaLine2 = Math.Sqrt(Math.Pow((a2 - a1), 2) + Math.Pow((b2 - b1), 2));
            Console.WriteLine("Length of a line is : " + LengthOfaLine2);

            if ( LengthOfaLine1.Equals(LengthOfaLine2) )
                Console.WriteLine("Length is equal");
            else
                Console.WriteLine("Length is different");
        }
    }
}
