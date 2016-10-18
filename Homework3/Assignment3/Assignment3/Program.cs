using System;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please type an integer value for n: ");
            string str;
            str = Console.ReadLine();
            int n = int.Parse(str);
            int iResult = n;
            for (int i = 1; i<n; i++)
            {
                iResult = iResult * (n - i);
            }
            Console.WriteLine("The calculated factorial for n is {0}", iResult);
                Console.ReadLine();
        }
    }
}
