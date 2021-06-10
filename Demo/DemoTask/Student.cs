using System;
using System.Collections.Generic;
using System.Text;

namespace DemoTask
{
    class Student
    {
        string Name, Address;
        int Mobile;

        public void GetData() {
            Console.WriteLine("Enter your Name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter your Address: ");
            Address = Console.ReadLine();
            Console.WriteLine("Enter your Mobile Number: ");
            Mobile = Convert.ToInt32(Console.ReadLine());
        }

        public void DisplayData()
        {
            Console.WriteLine("Student Name: " + Name);
            Console.WriteLine("Student Address: " + Address);
            Console.WriteLine("Student Mobile: " + Mobile);
        }


    }
}
