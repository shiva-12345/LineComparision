using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison
{
    class LinesCompare
    {
        static double x1;
        static double y1;
        static double x2;
        static double y2;
        static double a1;
        static double b1;
        static double a2;
        static double b2;

        static String val;
        public static void linesCompare()
        {
            Console.WriteLine("ELinesComparenter X and Y Co-ordinates values for 1st Line");
            val = Console.ReadLine();
            x1 = double.Parse(val);
            val = Console.ReadLine();
            y1 = double.Parse(val);
            val = Console.ReadLine();
            x2 = double.Parse(val);
            val = Console.ReadLine();
            y2 = double.Parse(val);
            Console.WriteLine("Enter X and Y Co-ordinates values for 2nd Line");
            val = Console.ReadLine();
            a1 = double.Parse(val);
            val = Console.ReadLine();
            b1 = double.Parse(val);
            val = Console.ReadLine();
            a2 = double.Parse(val);
            val = Console.ReadLine();
            b2 = double.Parse(val);
            double line1 = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            double line2 = Math.Sqrt(Math.Pow(a1 - a2, 2) + Math.Pow(b1 - b2, 2));
            Console.WriteLine("Length of 1st Line: " + line1 + " and Length of 2nd Line " + line2);
            if (line1 == line2)
                Console.WriteLine("Both lines are Equal");
            else if (line1 > line2)
                Console.WriteLine("Line1  is greater than Line2");
            else
                Console.WriteLine("Line1 is smaller than Line2");

        }
    }

}