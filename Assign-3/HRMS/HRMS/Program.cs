using EmployeeLib;
namespace HRMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = null;
            bool flag = true;
            while (flag)
            {
                int choice = menu();
                if (choice == 1)
                {
                    employee = new Manager();
                    employee.Accept();
                    Console.WriteLine("-------------------");
                    employee.Print();
                    Console.WriteLine("-------------------");
                    Console.WriteLine(employee.ToString());
                }
                else if (choice == 2)
                {
                    employee = new Supervisor();
                    employee.Accept();
                    Console.WriteLine("-------------------");
                    employee.Print();
                    Console.WriteLine("-------------------");
                    Console.WriteLine(employee.ToString());
                }
                else if(choice == 3) 
                {
                    employee = new WageEmp();
                    employee.Accept();
                    Console.WriteLine("-------------------");
                    employee.Print();
                    Console.WriteLine("-------------------");
                    Console.WriteLine(employee.ToString());
                }
                else
                {
                    Console.WriteLine("----Exit----");
                    flag = false;
                }
            }


        }

        public static int menu()
        {
            Console.WriteLine("Choose Designation");
            Console.WriteLine("1. Manager");
            Console.WriteLine("2. Supervisor");
            Console.WriteLine("3. Wage");
            Console.WriteLine("0. Exit");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
