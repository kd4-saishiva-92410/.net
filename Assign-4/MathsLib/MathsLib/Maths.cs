namespace MathsLib
{
    public class Maths
    {
        public void Add(double x , double y)
        {
            Console.WriteLine($"Add of {x} and {y} = {x + y}");
        }
        public void Subtract(double x, double y)
        {
            Console.WriteLine($"Difference of {x} and {y} = {x - y}");
        }
        public void Mul(double x, double y)
        {
            Console.WriteLine($"Product of {x} and {y} = {x * y}");
        }
        public void Div(double x, double y)
        {
            Console.WriteLine($"Division of {x} and {y} = {x / y}");
        }
    }
}
