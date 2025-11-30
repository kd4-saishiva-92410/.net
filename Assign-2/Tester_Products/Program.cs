namespace Tester_Products 
{ 
    using LibraryClass;

    internal class Program
    {
        static void Main(string[] args)
        {
                Product p1 = new Product(12,"Washing Machine",35000.50);
                Console.WriteLine(p1.DisplayInfo());
                ElectronicsProduct esp = new ElectronicsProduct(112,"Smartphone",2500.20,"Samsung",4);
                Console.WriteLine(esp.DisplayInfo());
            
        }
    }
}
