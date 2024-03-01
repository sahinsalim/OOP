namespace OOP_Inheritance
{
    public class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public Shape()
        {

        }

        public Shape(int x, int y)
        {
            X = x;
            Y = y;
        }

        public virtual void Draw() 
        {
            Console.WriteLine("Draw Method from Shape");
        }

        public void WorkWithDifferentObject(object o)
        {
            // as
            Shape shapefromParamater = o as Shape;
            if (shapefromParamater != null)
            {
                shapefromParamater.Draw();
            }
            Console.WriteLine("can't access to Null value.");

            // is
            //if(o is Shape)
            //{

            //}

        }


    }
}
