using System;

namespace Calc{
    class Calculator {
        public int add(int a, int b)
        {
            return a + b;
        }

        public int product(int a, int b)
    {
        return a * b;
    }

    static void Main(string[] args)
    {
        Calculator obj1 = new Calculator();
        Calculator obj2 = new Calculator();

        Console.WriteLine(obj1.add(20, 50));
        Console.WriteLine(obj2.product(30, 60));
        }
}

}