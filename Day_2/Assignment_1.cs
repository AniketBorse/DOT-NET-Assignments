using System;

namespace Assignment
{

    class Demo
    {
        static void Main()
        {
            string a, b;
            int n1, n2;
            a = Console.ReadLine();
            b = Console.ReadLine();

            n1 = int.Parse(a);
            n2 = int.Parse(b);

            int sum = n1 + n2;

            Console.WriteLine("Addition is: {0}", sum);
        }
    }
}