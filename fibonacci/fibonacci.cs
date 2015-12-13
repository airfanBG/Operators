using System;

class fibonacci
{
    static void Main()
    {
        Console.WriteLine("Enter an integer:");
        int n = int.Parse(Console.ReadLine());
        int a = 0;
        int b = 1;
        if (n == 0)
        {
            Console.WriteLine("Invalid input!");
            return;
        }
        else if (n == 1)
        {
            Console.WriteLine(0);
            return;
        }
        Console.Write("{0} {1}", a, b);
        for (int i = 2; i < n; i++)
        {
            int c = a + b;
            Console.Write(" {0} ", c);
            a = b;
            b = c;
        }
        Console.WriteLine();
    }
}
    

