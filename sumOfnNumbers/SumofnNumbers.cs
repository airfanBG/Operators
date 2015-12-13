using System;

class SumofnNumbers

{
    static void Main()
    {
        Console.WriteLine("Write \"N\" numbers:");
        double sum = 0;
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            double number = double.Parse(Console.ReadLine());
            sum += number;
            
        }
        Console.WriteLine("The sum is: "+sum);
    }
}

