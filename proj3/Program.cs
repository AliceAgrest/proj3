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

             //answer9
            int n, a;

            Console.WriteLine("Enter a number for loop ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number ");
            a = int.Parse(Console.ReadLine());

            bool flag = true;
           // bool flag1 = false;
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("Enter a number ");
                int x = int.Parse(Console.ReadLine());

                if (a <= x)
                    flag = true;
                else 
                    flag = false;

                 a = x;
            }
            if (flag == true)
                Console.WriteLine("Up set");
            else if (flag == false)
                Console.WriteLine("Down set");
            else
                Console.WriteLine("None set");

            Console.ReadLine();
        }
    }
}
