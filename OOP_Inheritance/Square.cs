namespace OOP_Inheritance
{
    public class Square : Rectangle
    {
        public Square()
        {
            
        }

        public Square(int x, int y) : base(x, y)
        {
            
        }

        new public void Calculate()
        {
            Console.WriteLine("Calculated by Square");
        }

    }
}
