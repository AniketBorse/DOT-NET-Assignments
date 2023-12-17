using System;

namespace DAC{
   class Student
    {
        public void disp1()
        {
            Console.WriteLine("DAC Student");
        }
    } 
}

namespace DBDA{
    class Student{
        public void disp2()
        {
            Console.WriteLine("DBDA Student");
        }
    }
}

namespace ConsoleApplication {
    class Display
    {
        public static void Main()
        {
            DAC.Student s1 = new DAC.Student();
            DBDA.Student s2 = new DBDA.Student();

            s1.disp1();
            s2.disp2();
        }
    }
}
