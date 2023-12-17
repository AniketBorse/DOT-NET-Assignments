using System;

namespace Assignment
{
    public class Account
    {
        static int getid;
        int Id;
        string Name;
        double Balance;
        static float Interestrate = 0.07f;
        const float minbal = 1000;

        static Account()
        {
            Console.WriteLine("State Bank of India");
        }

        public Account(string name, double balance)
        {
            Id = ++getid;
            Name = name;
            Balance = balance;
        }

        public int _Id
        {
            get
            {
                return Id;
            }
        }

        public string _Name
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }

        public double _Balance
        {
            get
            {
                return Balance;
            }

            set
            {
                if (value <= 0)
                {
                    throw new Exception("Invalid Amount");
                }

                Balance = value;
            }
        }

        public double deposit(int amt)
        {
            _Balance += amt;
            return _Balance;
        }

        public double withdraw(int amt)
        {
            if (_Balance < minbal)
            {
                throw new Exception("Minimum Balance should be 1000");
            }
            _Balance -= amt;
            return _Balance;
        }

        public static double CalculateInt(Account obj)
        {
            double interest = obj._Balance * Interestrate;
            obj._Balance = obj._Balance + interest;
            return interest;
        }

        public void Display()
        {
            Console.WriteLine("{0} {1} {2}", Id, Name, Balance);
        }
    }

    class Demo
    {
        static void Main()
        {
            Account a1 = new Account("Raj", 12000);
            a1.deposit(5000);
            a1.withdraw(1000);
            Account.CalculateInt(a1);
            a1.Display();
        }
    }
}