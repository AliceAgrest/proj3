using System;

namespace proj3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //answer1
            /*
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
            
            //answer2
            int numcount2 = 0, a;

            for (int x = 1; x <= 10; x++)
            {
                Console.WriteLine("Enter a number ");
                a = int.Parse(Console.ReadLine());

                if (a % 2 == 0)
                    numcount2++;
            }
            Console.WriteLine("Total even number is " + numcount2);
            
            //answer3
            int k, n;

            Console.WriteLine("Enter a big number ");
            k = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a small number ");
            n = int.Parse(Console.ReadLine());
            for (int c = n; c <= k; c++)
            {
                Console.WriteLine(" " + c);
            }
            
            //answer4
            int n, numcounteven = 0, numcount = 0;
            double remainder;

            Console.WriteLine("Enter a number ");
            n = int.Parse(Console.ReadLine());
            for(int i = 1;i <= n; i++)
            {
                if (i % 2 == 0)
                    numcounteven++;
                else
                    numcount++;
            }
            Console.WriteLine($"Total even number {numcounteven} and total odd number {numcount}");
            remainder = (double)numcounteven / numcount;
            Console.WriteLine($"The remainder of even numbers and odd numbers is {remainder}");
            
            //answer5
            int n, total = 1;

            Console.WriteLine("Enter a number ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i != n + 1; i ++)
            {
                total = i * total;
            }
            Console.WriteLine($"The total number is {total}");
            
            //answer6
            int n, sign = -1;

            Console.WriteLine("Enter a number ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1;i <= n; i++)
            {
                sign = sign * -1;
                Console.WriteLine(" " + (i * sign));
            }

            //answer7
            int n, a = 0, b = 1, res;

            Console.WriteLine("Enter a number ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"{a}");
            Console.WriteLine($"{b}");
            res = a + b;
            Console.WriteLine($"{res}");
            a = b;
            b = res;
            for (int x = 1; x < n; x++)
            {
                res = a + b;
                Console.WriteLine($"{res}");
                a = b;
                b = res;
            }

            //answer8
            int n;
            int isPrimeNumber = 0;

            Console.WriteLine("Enter a number ");
            n = int.Parse(Console.ReadLine());
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) {
                    Console.WriteLine("0");
                    isPrimeNumber = 1;
                    break;
                }
            }
            if(isPrimeNumber == 0)
                Console.WriteLine("1");
            */
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
