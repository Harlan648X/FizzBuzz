using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz();
        }

        static void FizzBuzz()
        {
            Console.WriteLine("Prints numbers 1-100 \nprints FIZZ when divisible by 3\nBuzz when divisible by 5\nFIZZBUZZ when divisible by both 3 and 5\n\n");

            for(int i = 1; i < 101; i++)
            {
                bool fizz = i % 3 == 0;
                bool buzz = i % 5 == 0;
                bool fizzBuzz = fizz && buzz;

                if (fizzBuzz)
                {
                    Console.WriteLine("FIZZBUZZ");
                }
                else if (fizz)
                {
                    Console.WriteLine("FIZZ");
                }
                else if (buzz)
                {
                    Console.WriteLine("BUZZ");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}
