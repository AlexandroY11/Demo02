namespace MyLibrary
{
    public class Product(int id, string name, decimal unitPrice, int unitInStock)
    {
        public int Id => id;
        public string Name => name;
        public decimal UnitPrice => unitPrice;
        public int UnitInStock => unitInStock; 
    }
}