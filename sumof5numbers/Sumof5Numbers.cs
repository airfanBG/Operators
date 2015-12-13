using System;

    class Sumof5Numbers
    {
        static void Main()
        {
            Console.WriteLine("Enter five numbers in a line, separated by a space:");
            string[] array = new string[5];
            double sum = 0;
            array = Console.ReadLine().Split();
            for (int i = 0; i < array.Length; i++)
            {
                sum += double.Parse(array[i]);
            }
            Console.WriteLine("The sum is: "+sum);
        }
    }
    

