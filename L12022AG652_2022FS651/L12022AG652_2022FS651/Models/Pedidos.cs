namespace L12022AG652_2022FS651.Models
{
    public class Pedidos
    {
        public int PedidoId { get; set; }
        public int MotoristaId { get; set; }
        public int ClienteId { get; set; }
        public int PlatoId { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }

        // Propiedades de navegación
        public Cliente Cliente { get; set; }
        public Plato Plato { get; set; }
        public Motorista Motorista { get; set; }
    }
}
