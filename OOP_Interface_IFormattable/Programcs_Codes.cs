using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interface_IFormattable
{
    internal class Programcs_Codes
    {

        private static void IFormattableExamples()
        {
            //Console.WriteLine(DateTime.Now.ToString("d"));

            var list = new List<Employee>()
            {
                new Employee()
                {
                    ID = 1,
                    Title = "Prof.",
                    FirstName = "Salim",
                    Lastname = "CAN",
                },
                new Employee()
                {
                    ID = 2,
                    Title = "Doç.",
                    FirstName = "Melike",
                    Lastname = "CAN",
                },
                new Employee()
                {
                    ID = 3,
                    Title = "Dr.",
                    FirstName = "Emjan",
                    Lastname = "TAŞ",
                }
            };

            foreach (var item in list)
            {
                Console.WriteLine(item.ToString("FI"));
            }
        }

    }
}
