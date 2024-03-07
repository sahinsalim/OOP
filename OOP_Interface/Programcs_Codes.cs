using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interface
{
    internal class Programcs_Codes
    {


        private static void SaverAccountInterfaceExamples()
        {
            var saver = new SaverAccount();
            saver.PayIn(500);
            saver.withdraw(150);
            saver.withdraw(400);
            Console.WriteLine("Current Balance: " + saver.Balance);
            Console.WriteLine(saver);
        }

    }
}
