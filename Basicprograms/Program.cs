﻿namespace Basicprogram
{
    public class Factors
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Value: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int i = 0;

            for (i = 1; i <= N; i++)
            {
                if (N % i == 0)
                {
                    Console.WriteLine(i + " is a Factor of " + N);
                }
                else
                {
                    Console.WriteLine(i + " is not a Factor of " + N);
                }
                Console.ReadLine();

            }
        }
    }
}