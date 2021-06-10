using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise7
{
    class BankAccount
    {
        double balance;
        string pin;
        int attempt;
        int limit;

        public BankAccount(double init_amt, string password = "0000")
        {
            this.balance = init_amt;
            this.pin = password;
            this.attempt = 0;
            this.limit = 3;
        }
        public string Pin
        {
            get { return pin; }
            set { pin = value; }
        }

        public int Attempt
        {
            get { return attempt; }
            set { attempt = value; }
        }

        public int Limit
        {
            get { return limit; }
            set { limit = value; }
        }

        public bool Validate(string inp)
        {
            return inp == pin;
        }



        public double CheckBalance()
        {
            return balance;
        }

        public void WithDraw(double amt)
        {
            balance -= amt;
            Console.WriteLine($"You have withdrawn {amt} RS from your account.");
        }

        public void Deposit(double amt)
        {
            balance += amt;
            Console.WriteLine($"You have deposited {amt} RS into your account.");
        }
    }
}
