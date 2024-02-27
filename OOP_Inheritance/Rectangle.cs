namespace OOP_Inheritance
{
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Rectangle drawing task...");
        }

        public void Calculate()
        {
            Console.WriteLine("Calculated by Rectangle");
        }
    }

}
