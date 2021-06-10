using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to be reversed:");
            string s = Console.ReadLine();
            string r = "";
            int n = s.Length;
            for (int i = n-1; i>=0; i--)
            {
                r = r + s[i];
            }
            Console.WriteLine($"The reversed string is {r} ");
        }
    }
}
