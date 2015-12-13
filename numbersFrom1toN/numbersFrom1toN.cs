using System;

    class numbersFrom1toN
    {
        static void Main()
        {
            Console.WriteLine("Write \"N\" numbers:");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
               
                Console.WriteLine(i);
            }
        }
    }

