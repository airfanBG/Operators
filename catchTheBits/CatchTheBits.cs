using System;

    class CatchTheBits
    {
        static void Main()
        {
            Console.WriteLine("Write count of numbers:");
            int numbersCount = int.Parse(Console.ReadLine());
            Console.WriteLine("Write a step:");
            byte step = byte.Parse(Console.ReadLine());
            int index = 0;
            
            for (int i = 0; i < numbersCount; i++)
            {
                Console.WriteLine("Write a number:");
                int number = int.Parse(Console.ReadLine());
                for (int bit=6; bit>=0; bit--)
                {
                    index++;
                    if ((step==1)||(index%step==1))
                    {
                       number= number^(1<<bit);
                    }
                }
                Console.WriteLine("The number is: "+number);
 



            }

        }
    }
