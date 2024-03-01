using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Abstract_Class_Methods
{
    internal class Program_Codes
    {
        private static void Abstract_Class_and_Methods()
        {
            //To create an abstract method,
            //the class must also be abstract.
            //Then the classes that inherit this class
            //must override and organise the required
            //abstract method.
            //At the same time, new objects cannot be defined
            //from abstract classes.For this, objects can be
            //generated from the classes that inherit
            //the abstract class.
            var arr = new int[] { 3, 2, 5, 1, 7 };
            var minheap = new MinHeap();
            var maxheap = new MaxHeap();

            foreach (var item in arr)
            {
                minheap.Insert(item);
                maxheap.Insert(item);
            }

            Console.WriteLine(minheap.Extract());
            Console.WriteLine(maxheap.Extract());
        }

    }
}
