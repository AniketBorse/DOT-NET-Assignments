using System;

namespace Assignment
{
    class Calculator
    {
        public int Square(int x)
        {
            return x * x;
        }

        public int Cube(int x)
        {
            return (x * x * x);
        }

        public int Round(float x)
        {
            int r = (int)x;
            return r;
        }
    }

    class Demo
    {
        static void Main()
        {
            Calculator obj = new Calculator();
            Console.WriteLine(obj.Square(17));
            Console.WriteLine(obj.Cube(8));
            Console.WriteLine(obj.Round(8.6f));
        }
    }
}