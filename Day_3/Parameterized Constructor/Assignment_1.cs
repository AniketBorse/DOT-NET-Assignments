using System;

namespace Assignment
{
    class Student
    {
        string name;
        int maths;
        int science;
        int eng;

        public Student(string nm, int mt, int sci, int en)
        {
            name = nm;
            maths = mt;
            science = sci;
            eng = en;
        }

        public int Total()
        {
            int total;
            total = maths + science + eng;
            return total;
        }

        public string Display()
        {
            int total_marks = Total();
            return string.Format("Name: {0} Marks: {1}/300", name, total_marks);
        }
    }

    class Demo
    {
        static void Main()
        {
            Student s1 = new Student("Aniket", 90, 80, 70);
            Student s2 = new Student("Siddhesh", 100, 100, 100);
            Student s3 = new Student("Yash", 100, 90, 80);

            Console.WriteLine(s1.Display());
            Console.WriteLine(s2.Display());
            Console.WriteLine(s3.Display());
        }
    }
}