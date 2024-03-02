using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    internal class Programcs_codes
    {
        private static void As_Is_operators()
        {
            //  Check WorkWithDifferentObject from Shape.cs
            var s1 = new Rectangle(10, 20);
            var s2 = new Circle(25, 35);
            s1.WorkWithDifferentObject(s2);
        }
        private static void SealedNotes()
        {
            // Sealed Notes.
            // The xxx keyword is in a sense the last stop
            // for this event. It cannot be inherited
            // if used in a class, and it cannot be overridden
            // if used in a method 
        }
        private static void Constructor_Examples()
        {
            var s1 = new Rectangle(10, 20);
            Console.WriteLine("{0} {1}", s1.X, s1.Y);

            var s2 = new Circle(11, 22);
            Console.WriteLine("{0} {1}", s2.X, s2.Y);

            var s3 = new Square(6, 12);
            Console.WriteLine("{0} {1}", s3.X, s3.Y);
        }
        private static void Polymorphism()
        {
            var shapes = new List<Shape>()
            {
                new Rectangle(),
                new Circle(),
                new Triangle(),
                new Square(),
            };

            foreach (var shape in shapes)
            {
                shape.Draw();
            }

            new Square().Calculate();

        }
        private static void Inheritance_Examples()
        {
            // virtual keyword is important (on Shape class' Draw method).
            var s1 = new Rectangle();
            var s2 = new Circle();

            s1.X = 1;
            s1.Y = 2;
            Console.WriteLine("{0}  {1}", s1.X, s1.Y);
            s1.Draw();

            s2.X = 2;
            s2.Y = 3;
            Console.WriteLine("{0}  {1}", s2.X, s2.Y);
            s2.Draw();

            new Triangle().Draw();


            Console.ReadKey();
        }
    }
}
