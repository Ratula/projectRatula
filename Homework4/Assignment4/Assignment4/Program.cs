using System;

namespace Assignment4
{
    class Program
    {
        static void Main()

        {
            Console.Write("Please enter a number: ");
            string str;
            str = Console.ReadLine();
            int n = int.Parse(str);
            for (int m = 1; m <= n; m++)
            {
                int iResult = m;
                for (int i = 1; i < m; i++)
                {
                    iResult = iResult * (m - i);
                }
                Console.WriteLine("Factorial of the number " + m + " is: " + iResult);
            }

            Console.ReadLine();
        }
    }
}