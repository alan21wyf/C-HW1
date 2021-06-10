using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of rows:");
            int row = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < row; i++)
            {
                int n = 1 + i * 2;
                int b = row - i - 1;
                for (int k = 0; k < b; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < n; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = row-2; i >= 0; i--)
            {
                int n = 1 + i * 2;
                int b = row - i - 1;
                for (int k = 0; k < b; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < n; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
