using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Employee
    {
        private string name;
        private double salary;
        public string Name { get { return name; } set { name = value; } }
        public double Salary
        {
            get { return salary; }
            set
            {
                if (value >= 0 && value <= 1000000)
                    salary = value;
                else
                    Console.WriteLine("Зарплата не может быть отрицательной.");
            }
        }
        public Employee(string name, double salary) : this(name) 
        {
            this.name = name;
            this.salary = salary >= 0 && salary <= 1000000 ? salary : 0;
        }
        public Employee(string name)
        {
            this.name = "Иван";
            this.salary = 80000;
        }
        public void Work()
        {
            Console.WriteLine($"{name} работает, зарплата {salary}");
        }
    }





    internal class Program
    {
        static void Main()
        {
            Employee employee = new Employee("Иван", 80000);
            Employee employee1 = new Employee("Анна", 50000);
            employee.Work();
            employee.Salary = -1000;
            employee1.Work();


        }
    }
}
