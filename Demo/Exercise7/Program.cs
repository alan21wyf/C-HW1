using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba1 = new BankAccount(1000);
            Console.WriteLine("Enter Your Pin Number (If this is your first time using our service, the default pin number is 0000):");
            string pw = Console.ReadLine();
            if (ba1.Validate(pw))
            {
                bool q = false;
                while (q == false)
                {
                    Console.WriteLine("\n\n\n**************Welcome to ATM Service***************\n");
                    Console.WriteLine("1. Check Balance\n");
                    Console.WriteLine("2. Withdraw Cash\n");
                    Console.WriteLine("3. Deposit Cash\n");
                    Console.WriteLine("4. Change Your Pin Number\n");
                    Console.WriteLine("5. Quit\n");
                    Console.WriteLine("*****************************************************");
                    Console.WriteLine("Enter your choice: ");
                    string choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1":
                            double balance = ba1.CheckBalance();
                            Console.WriteLine($"Your Balance in Rs: {balance}");
                            break;
                        case "2":
                            Console.WriteLine("Enter the amount you wish to withdraw:");
                            double withdraw = Convert.ToDouble(Console.ReadLine());
                            ba1.WithDraw(withdraw);
                            break;
                        case "3":
                            Console.WriteLine("Enter the amount you wish to deposit:");
                            double deposit = Convert.ToDouble(Console.ReadLine());
                            ba1.Deposit(deposit);
                            break;
                        case "4":
                            if (ba1.Attempt < ba1.Limit)
                            {
                                Console.WriteLine("Enter your old pin number:");
                                string oldpw = Console.ReadLine();
                                if (ba1.Validate(oldpw))
                                {
                                    Console.WriteLine("Enter your new pin number(numbers only):");
                                    string newpw = Console.ReadLine();
                                    ba1.Pin = newpw;
                                    Console.WriteLine("The pin number has been updated.");
                                }
                                else
                                {
                                    if (ba1.Attempt < ba1.Limit)
                                    {
                                        Console.WriteLine("The pin numebr your entered is incorrect. Please try again.");
                                        ba1.Attempt += 1;
                                        Console.WriteLine($"You have {ba1.Limit - ba1.Attempt} times left.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please go to the counter with a valid ID to reset your PIN number.");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please go to the counter with a valid ID to reset your PIN number.");
                            }

                            break;
                        case "5":
                            Console.WriteLine("Thank you for using our services! Have a good day!");
                            q = true;
                            break;
                    }
                }


            }
            else
            {
                Console.WriteLine("You are a thief. Police is on the way.");
            }
        }
    }
}
