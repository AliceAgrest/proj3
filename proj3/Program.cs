using System;

namespace proj3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //answer 1
            int numcount = 0 ;
            
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    Console.WriteLine("The divisible number with 3 and 7 is "+ i);
                    numcount++;
                }
            }
            Console.WriteLine("the count numbers that divisble with 3 and 7 between 1-100 are " + numcount);

            Console.ReadLine();
        }
    }
}
