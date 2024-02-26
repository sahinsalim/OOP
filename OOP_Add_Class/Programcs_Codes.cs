using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Add_Class
{
    internal class Programcs_Codes
    {

        private static void EmployeeExamples_v2()
        {
            var list = new List<Employee>()
            {
                new Employee(){FirstName = "Salim", LastName = "Şahin", Age = 21},
                new Employee("Emircan", "Kabataş", 22),
                new Employee("Rahim","Işık",22)
            };

            //Employee e1 = new Employee(){FirstName = "Salim", LastName = "Şahin", Age = 21};
            //Employee e2 = new Employee("Rahim","Işık",22);
            //Employee e3 = new Employee("Emircan", "Kabataş", 22);
            //list.Add(e1); 
            //list.Add(e2); 
            //list.Add(e3);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        private static void EmployeeExamples()
        {
            Employee employee = new Employee();
            employee.FirstName = "Salim";
            employee.LastName = "Şahin";
            employee.Age = 21;

            //Console.WriteLine(employee.FirstName);
            //Console.WriteLine(employee.LastName);
            //Console.WriteLine(employee.Age);

            Employee employee2 = new Employee("Melike", "Şahin", 21);
            //Console.WriteLine(employee2.FirstName);
            //Console.WriteLine(employee2.LastName);
            //Console.WriteLine(employee2.Age);

            //Console.WriteLine($"{employee2.FirstName} " +
            //    $"{employee2.LastName} " +
            //    $"{employee2.Age} ");

            Employee employee3 = new Employee("Gamze", "Şahin", 25);

            Console.WriteLine(employee3);
            Console.WriteLine(employee2);
            Console.WriteLine(employee);

            Console.ReadKey();
        }
    }
}
