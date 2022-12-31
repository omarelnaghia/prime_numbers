using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second_project
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter The Lower Bound Of The Range");
            int first = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter The Upper Bound Of The Range");
            int second = int.Parse(Console.ReadLine());

            Console.WriteLine("The Prime Numbers In The Range Are :");
            for (int i = first; i <= second; i++)
            {
                bool isPrime = true;

                if (i == 2 | i == 3)
                {
                    Console.WriteLine(1);
                }
                else if (i == 1 | i % 2 == 0)
                {
                    continue;
                }
                else
                {
                    for (int n = 3; n <= Math.Sqrt(i); n += 2)
                    {
                        if (i % n == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime)
                    {
                        Console.WriteLine(i);
                    }
                    Console.ReadKey();
                }
            }
        }
    }
}













