using System;

    class LelyaVanche
    {
        static void Main()
        {
            double h = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());

            double workingHours = (double)d * 0.9 * 12*((double)p/100);
            //Console.WriteLine("{0}",Math.Floor(workingHours));
            if (workingHours<h)
            {
                workingHours -= h;
                Console.WriteLine("No "+ Math.Floor(workingHours));
            }
            else
            {
                workingHours -= h;
                Console.WriteLine("Yes " + Math.Floor(workingHours));
            }

        }
    }
