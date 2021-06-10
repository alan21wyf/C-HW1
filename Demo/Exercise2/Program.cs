using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Arithmetic a = new Arithmetic();
            double f, s;
            Console.WriteLine("Enter the first number: ");
            f = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select the operation you want to proceed: \n 1.Addition. \n 2.Subtraction. \n 3.Division. \n 4.Multiplication. \n (For example, enter '1' to do addition.)");
            int so = Convert.ToInt32(Console.ReadLine());
            double res;
            switch (so)
            {
                case 1:
                    res = a.Addition(f, s);
                    Console.WriteLine($"{f} + {s} = {res}");
                    break;
                case 2:
                    res = a.Subtract(f, s);
                    Console.WriteLine($"{f} - {s} = {res}");
                    break;
                case 3:
                    if (s == 0)
                    {
                        Console.WriteLine("The divisor should not be 0, please try another number.");
                        break;
                    } else
                    {
                        res = a.Division(f, s);
                        Console.WriteLine($"{f} / {s} = {res}");
                        break;
                    }
                case 4:
                    res = a.Multiplication(f, s);
                    Console.WriteLine($"{f} * {s} = {res}");
                    break;
            }
        }
    }
}
