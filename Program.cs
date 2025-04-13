using System;

namespace IEnumerableIQueryable
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new EmployeeContext("Presist Security Info = False; Integration Security = true")

            // IEumerable<Employee> employees = context.Employees.Where(e => e.Id > 1);

            IQueryable<Employee> employees = context.Employees.Where(e => e.Id > 1);

            // var topEmployee = employees.Take(2);

            // foreach (var employee in topEmployee)
            // {
            //     Console.WriteLine($"Name - {employee.FirstName} {employee.LastName}");
            // }

            var topEmployee = employees.Take(2);


            foreach (var employee in topEmployee)
            {
                Console.WriteLine($"Name - {employee.FirstName} {employee.LastName}");
            }
        }
    }
}