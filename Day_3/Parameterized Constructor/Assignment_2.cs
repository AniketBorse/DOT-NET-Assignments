using System;

namespace Assignment
{
    class Account
    {
        string name;
        int id;
        int balance;

        public Account(string nm, int i, int bal)
        {
            name = nm;
            id = i;
            balance = bal;
        }

        public void deposit(int amt)
        {
            balance = balance + amt;
        }

        public void withdraw(int amt)
        {
            balance = balance - amt;
        }

        public void display()
        {
            Console.WriteLine("{0} {1}", name, balance);
        }
    }

    class Demo
    {
        static void Main()
        {
            Account a1 = new Account("ABC", 1, 6000);
            a1.deposit(1000);
            a1.withdraw(500);
            a1.display();

            Account a2 = new Account("XYZ", 2, 9000);
            a2.deposit(2000);
            a2.withdraw(5000);
            a2.display();
        }
    }
}
