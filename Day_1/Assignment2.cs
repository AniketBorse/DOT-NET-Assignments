using System;

namespace Factorial{
    class Factorial { 
        public void fact(int x)
        {
            int f = 1;
            for(int i = 1; i<=x; i++)
            {
                f = f * i;
            }
            Console.WriteLine(f);
        }
        static void Main(string[] args)
        {
            Factorial obj1 = new Factorial();
            obj1.fact(5);
        }
    }
}