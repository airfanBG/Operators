using System;

    class formatingNumbers
    {
        static void Main()
        {
            Console.WriteLine("Write a number \"a\" 0<a<500");
            int a = Convert.ToInt32(Console.ReadLine());
            string bit = Convert.ToString(a,2);
            double b = -0.5559;
            double c = 10000;
            if (a < 0 || a > 500)
            {
                Console.WriteLine("Not a valid number");
            }
            else
            {
                Console.WriteLine("|{0,-10:x}|{1,10}|{2,10:F2}|{3,-10:F3}|", a, bit, b, c);
            }
        }
    }

