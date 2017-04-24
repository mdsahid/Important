namespace InventoryManagementSystemApp.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string  Code { get; set; }
        public string  Name { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }

        public double TotalPrice
        {
            get { return UnitPrice*Quantity; }
            
        }

        public int CategoryId { get; set; }
    }
}