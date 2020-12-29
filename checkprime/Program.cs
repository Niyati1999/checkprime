using System;

namespace checkprime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int cnt = 0;
            Console.WriteLine("Enter a number to check wheather it is prime or not !!");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    cnt++;
                }
            }
            if (cnt == 2)
            {
                Console.WriteLine("Number is Prime !!");
            }
            else
            {
                Console.WriteLine("NUmber is not a prime !!");
            }
        }
    }
}
