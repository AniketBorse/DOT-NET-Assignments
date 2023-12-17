using System;

namespace Assignment
{
    class Even_no
    {
        public int[] allEven (int a, int b, out int count)
        {
            int[] arr = new int[10];
            count = 0;
            for (int i = a, j = 0; i<=b; i++)
            {
                if (i % 2 == 0)
                {
                    arr[j] = i;
                    j++;
                    count++;
                }
            }
            
            return arr;
        }
    }

    class Perform
    {
        public static void Main()
        {
            int ev;
            int[] a;
            Even_no e = new Even_no();
            a = e.allEven(1,18, out ev);
            for (int i = 0; i < ev; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
    }
}
