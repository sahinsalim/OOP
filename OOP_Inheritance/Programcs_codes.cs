﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    internal class Programcs_codes
    {
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