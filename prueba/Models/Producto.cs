namespace prueba.Models
{
    public class Producto
    {
        public int Id { get; set; } // Identificador único de cada producto
        public string Nombre { get; set; } = string.Empty; // Nombre del producto
        public int Cantidad { get; set; } // Cantidad disponible en inventario
    }
}

