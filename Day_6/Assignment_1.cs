using System;

namespace Assignment
{
    class Digits
    {
        public int sum(int a, out int f)
        {
            int s = 0;
            f = 0;
            while (a != 0)
            {
                int r = a % 10;
                s = s + r;
                a = a / 10;
                f++;
            }
            return s;
        }
    }

    class Perform
    {
        public static void Main()
        {
            int dig;
            Digits d = new Digits();
            Console.WriteLine(d.sum(124, out dig));
            Console.WriteLine(dig);
        }
    }
}
