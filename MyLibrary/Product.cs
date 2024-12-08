namespace MyLibrary
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }
    
        public Product(int id, string name, decimal unitPrice, int unitInStock) 
        { 
            Id = id;
            Name = name;
            UnitPrice = unitPrice;
            UnitInStock = unitInStock;
        }
    }
}