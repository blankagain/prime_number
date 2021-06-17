using System;

namespace Prime_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select from the options:");
            Console.WriteLine("1. Get prime numbers between 0 to 100");
            Console.WriteLine("2. Check the number if it is prime");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {
                Console.WriteLine("prime numbers between 0 to 100");
                //int x;
                bool prime = true;
                {
                    for (int i = 2; i <= 100; i++)
                    {
                        for (int j = 2; j <= 100; j++)
                        {
                            if (i != j && i % j == 0)
                            {
                                prime = false;
                                break;
                            }
                        }
                        if (prime) { Console.WriteLine("Prime no. " + i); }
                        prime = true;
                    }

                }

            }
            if (a == 2)
            {
                Console.WriteLine("Input the number to be checked");
                int o = Convert.ToInt32(Console.ReadLine());
                for (int x = 2; x <= o; x++)
                {
                    if (x % o == 0)
                    {
                        Console.WriteLine(" It's not a prime number");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("It is a prime number");

                    }
                }
            }
        }
    }
}
