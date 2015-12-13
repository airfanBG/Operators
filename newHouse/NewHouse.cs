using System;

    class NewHouse

    {
        static void Main()
        {
            Console.WriteLine("Write a number");
            int n = int.Parse(Console.ReadLine());
          
            for (int m = 1; m <n; m++)
            {
                
                string roof1 = new string('*', m);
                string roof = new string('-', (n-m) / 2);
                string wholeroof = string.Format(" {0}{1}{0}", roof, roof1);
                Console.WriteLine(wholeroof);
                if ((n - m) / 2 == 0)
                {
                    break;
                }
            }




            for (int i = 0; i < n; i++)
            {
                string body = "|";
                string body1 = new string('*', n - 2);
                string wholebody = string.Format("{0}{1}{0}",body,body1);
                Console.WriteLine(wholebody);
            }




        }
    }
