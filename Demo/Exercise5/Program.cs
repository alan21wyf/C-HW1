using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of Rows:");
            int row = Convert.ToInt32(Console.ReadLine());
            int curr = 1;
            bool one = true;
            for (int i = curr; i <= row; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (one)
                    {
                        Console.Write(1);
                        one = false;
                    }
                    else
                    {
                        Console.Write(0);
                        one = true;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
