using System;

namespace Assignment
{
    class Demo
    {
        static void Main()
        {
            string a, b;
            a = Console.ReadLine();
            b = Console.ReadLine();

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b);
            Console.WriteLine(Object.ReferenceEquals(a, b));
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}