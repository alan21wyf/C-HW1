using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 integer numbers and output all Armstrong numbers in between them.");
            Console.WriteLine("Enter the first number (smaller one):");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number (bigger one):");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Armstrong Numbers between {first} and {second} are:");
            for (int num = first; num <= second; num++)
            {
                int sum = 0, temp = num;
                int nod = Convert.ToInt32(Math.Floor(Math.Log10(temp) + 1));
                //Console.WriteLine($"{temp} {nod}");
                while (temp > 0)
                {
                    sum = sum + Convert.ToInt32(Math.Pow(temp % 10, nod));
                    temp = temp / 10;
                }
                if (sum == num)
                {
                    Console.WriteLine(sum);
                }
            }
        }
    }
}
