using System;

    class QuadricEquation
    {
        static void Main()
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double D = Math.Pow(b, 2) - 4 * a * c;
            if (D < 0)
            {
                Console.WriteLine("D has no real roots.");
            }
            else if (D == 0)
            {
                double D1 = -(b / (2 * a));
                Console.WriteLine("D has one root: " + D1);

            }
            else
            {

                Console.WriteLine("D= " + D);
                double x = (-b + Math.Sqrt(D)) / (2 * a);
                double y = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine(x);
                Console.WriteLine(y);
            }
        }
    }

