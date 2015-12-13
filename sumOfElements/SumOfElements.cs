using System;

class SumOfElements
{
    static void Main()
    {
        Console.WriteLine("Write count of numbers");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int max = int.MinValue;
        int sum = 0;
        Console.WriteLine("Enter numbers:");

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
            sum = sum + array[i];

            
            if (array[i] > max)
            {
                max = array[i];
            }
        }
       // Console.WriteLine(max);
        //Console.WriteLine(sum);
        if ((sum-max==max))
        {
           Console.WriteLine("Yes, sum= "+max); 
        }
        else
        {
            int diff = Math.Abs(sum-2*max);
            Console.WriteLine("No, diff= " +diff);
        }
    }
}


