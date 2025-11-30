using MathLibrary;

namespace MathCal
{
    internal class Program
    {
        static int menulist()
        {
            Console.WriteLine("===MENU===");
            Console.WriteLine("0.EXIT");
            Console.WriteLine("1.ADD");
            Console.WriteLine("2.SUB");
            Console.WriteLine("3.MUL");
            Console.WriteLine("4.DIV");
            Console.WriteLine("Enter your choice");
            string choice = Console.ReadLine();
            int ch = Convert.ToInt32(choice);
            return ch;

        }
        static void Main(string[] args)
        {

            Maths maths = new Maths();
            Console.WriteLine("Enter 1st number:");
            string str1 = Console.ReadLine();
            int num1 = Convert.ToInt32(str1);

            Console.WriteLine("Enter 2nd number:");
            string str2 = Console.ReadLine();
            int num2 = Convert.ToInt32(str2);

            int choice;
            while ((choice=menulist())!=0)
            {
                switch (choice)
                {

                    case 0: Console.WriteLine("EXIT");
                        
                        break;

                    case 1:
                            Console.WriteLine("ADD");
                            int add = maths.Add(num1, num2);
                            Console.WriteLine($"Result: {add}");
                            break;

                    case 2:
                        Console.WriteLine("SUB");
                        int sub = maths.Sub(num1, num2);
                        Console.WriteLine($"result: {sub}");
                        break;

                    case 3:
                        Console.WriteLine("MUL");
                        int mul = maths.Mul(num1, num2);
                        Console.WriteLine($"Result: {mul}");
                        break;

                    case 4:
                        Console.WriteLine("DIV");
                        int div = maths.Div(num1, num2);
                        Console.WriteLine($"Result: {div}");
                        break;
                }
            }
                  
            //int add = maths.Mul(num1, num2);
            //Console.WriteLine($"Add:{add}");
            //int sub = maths.Sub(num1, num2);
            //Console.WriteLine($"Sub::{sub}");
            //int mul = maths.Mul(num1, num2);
            //Console.WriteLine($"Mul: {mul}");
            //int div = maths.Div(num1, num2);
            //Console.WriteLine($"Div: {div}");
        }
        
    }
}
