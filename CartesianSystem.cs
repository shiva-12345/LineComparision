using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison
{
    class CartesianSystem
    {
        static int x1;
        static int y1;
        static int x2;
        static int y2;

        static String val;
        public static void lengthOFLine()
        {
            Console.WriteLine("Enter X and Y Co-ordinate values");
            val = Console.ReadLine();
            x1 = Convert.ToInt32(val);
            val = Console.ReadLine();
            y1 = Convert.ToInt32(val);
            val = Console.ReadLine();
            x2 = Convert.ToInt32(val);
            val = Console.ReadLine();
            y2 = Convert.ToInt32(val);
            double distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Sqrt(Math.Pow(y1 - y2, 2)));

            Console.WriteLine("Length Of Line :" + distance);
        }
    }
}