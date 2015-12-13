using System;

    class NumberInInterval
    {
        static void Main()
        {
            int a = 5;
            int b = 30;
            int start = 0;
            for (int i = a; i <= b; i++)
            {
                if (i%5==0)
                {
                    start ++ ;
                }
               
            }
            Console.WriteLine(start);

        }
    }

