using System;

    class CirclePerimeterArea
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            double r2 = double.Parse(Console.ReadLine());

            double area = Math.PI*Math.Pow(r,2);
            double perimeter = 2 * Math.PI * r;
            Console.WriteLine("r="+r+" area is"+"= {0:F2}", area);
            Console.WriteLine("r="+r+" perimeter is"+"= {0:F2}",perimeter);

            double area1 = Math.PI * Math.Pow(r2, 2);
            double perimeter1 = 2 * Math.PI * r2;
            Console.WriteLine("r="+r2+" area is" + "= {0:F2}", area1);
            Console.WriteLine("r="+r2+" perimeter is"+"= {0:F2}", perimeter1);
        }
    }

