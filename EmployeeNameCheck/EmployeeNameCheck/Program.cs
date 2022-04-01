using System;

namespace EmployeeNameCheck
{
    class Program
    {
        static void Main(string[] args)
        {   
            Employee employee = new Employee("Programmer");
            employee.FullName = "Samir";
            Console.WriteLine(employee.GroupNo);
            Console.WriteLine(employee.FullName);

            Employee employee2 = new Employee("programmer");
            employee2.FullName = "Sam3ir";
            Console.WriteLine(employee2.GroupNo);
            Console.WriteLine(employee2.FullName);
        }
    }
}
