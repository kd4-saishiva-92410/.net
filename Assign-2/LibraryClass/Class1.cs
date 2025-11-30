namespace LibraryClass
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }
        public Product(int productID, string productName, double price)
        {
            ProductID = productID;
            ProductName = productName;
            Price = price;
        }
        public virtual string DisplayInfo()
        {
            return $"ProductID:{ProductID} ProductName:{ProductName} ProductPrice:{Price}"; 
        }
    }

    public class ElectronicsProduct : Product
    {
        public string Brand { get; set; }
        public int WarrantyinYears { get; set; }

        public ElectronicsProduct() 
        { }

        public ElectronicsProduct(int productID, string productName, double price, string brand, int warrantyinYears) : base(productID, productName, price)
        {
            Brand = brand;
            WarrantyinYears = warrantyinYears;
        }

        public override string DisplayInfo()
        {
            
            return base.DisplayInfo() + $"Brand {Brand} Warrany in Years: {WarrantyinYears}";
        }
    }
}
