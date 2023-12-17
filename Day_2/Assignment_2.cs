using System;

namespace Assignment
{
    class Demo
    {
        static void Main()
        {
            string a;
            float b;

            a = Console.ReadLine();
            //b = float.Parse(a);
            //b = Convert.ToSingle(a);
            bool a1 = float.TryParse(a, out b);
            if (a1 == true)
            {
                Console.WriteLine("Square is {0}", b * b);
            }
        }
    }
}
