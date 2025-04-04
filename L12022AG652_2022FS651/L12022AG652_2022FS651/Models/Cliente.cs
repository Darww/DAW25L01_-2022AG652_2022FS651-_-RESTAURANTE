namespace L12022AG652_2022FS651.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string NombreCliente { get; set; }
        public string Direccion { get; set; }
    }

    public class Pedidos
    {
        public int PedidoId { get; set; }
        public int MotoristaId { get; set; }
        public int ClienteId { get; set; }
        public int PlatoId { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
    }

    public class Plato
    {
        public int PlatoId { get; set; }
        public string NombrePlato { get; set; }
        public decimal Precio { get; set; }
    }

    public class Motorista
    {
        public int MotoristaId { get; set; }
        public string NombreMotorista { get; set; }
    }



}

