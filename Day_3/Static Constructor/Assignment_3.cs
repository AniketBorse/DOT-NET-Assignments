using System;

namespace Assignment
{
    public class Employee
    {
        int id;
        string name;
        double salary;
        double netsal;
        Dept d;

        public enum Dept
        {
            MKV,
            ADMIN,
            ADV
        }

        public Employee(int i, string nm, double sal, Dept d)
        {
            id = i;
            name = nm;
            salary = sal;
            Dept d2 = d;
        }

        public double paytax(double p)
        {
            double tax = salary * p;
            netsal = salary - tax;
            return tax;
        }

        public string Display()
        {
            paytax(0.12);
            return string.Format("{0} {1} {2}", name, netsal, d);
        }
    }

    class Demo
    {
        static void Main()
        {
            Employee emp = new Employee(1, "Raj", 50000, Employee.Dept.MKV);
            Console.WriteLine(emp.Display());
        }
    }
}