using System;

namespace Assignment
{
    class MyClass
    {
        int sum = 0, r;
        public int Digit(int a, out int count)
        {
            count = 0;
            while(a > 0)
            {
                r = a % 10;
                sum = sum + r;
                a /= 10;
                count++;
            }
            return sum;
        }
    }
    class Demo
    {
        static void Main()
        {
            MyClass m = new MyClass();
            int num = 123;
            int c;

            Console.WriteLine(m.Digit(num, out c));
            Console.WriteLine(c);
        }
    }
}