using System;

namespace Assignment
{
    class Employee
    {
        string name;
        int id;
        double Salary;
        int netSalary;

        static Employee()
        {
            Console.WriteLine("State Bank of India");
        }

        public Employee(string nm, int i, double sal)
        {
            name = nm;
            id = i;
            Salary = sal;
        }

        public double Calculatesal()
        {
            double netsal;
            netsal = Salary - Salary * 0.1;
            return netsal;
        }

        public void display()
        {
            Salary = Calculatesal();
            Console.WriteLine("{0} {1}", name, Salary);
        }
    }

    class Demo
    {
        static void Main()
        {
            Employee e1 = new Employee("ABC", 100, 50000);
            e1.Calculatesal();
            e1.display();

            Employee e2 = new Employee("XYZ", 200, 60000);
            e2.Calculatesal();
            e2.display();

            Employee e3 = new Employee("MNO", 300, 70000);
            e3.Calculatesal();
            e3.display();
        }
    }
}
