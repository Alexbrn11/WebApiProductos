namespace WebApiProductos.Models
{
    public class Product
    {
        public int Id { get; set; }
        public required string Description { get; set; }
        public required int Precio { get; set; }
    }
}
