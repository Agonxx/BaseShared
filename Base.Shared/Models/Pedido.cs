using Base.Shared.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Base.Shared.Models
{
    public class Pedido
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sabor { get; set; }
        public string Adicional { get; set; }
        public ComumEnums.ETamanho Tamanho { get; set; } = ComumEnums.ETamanho.Pequeno;
        [Column(TypeName = "decimal(18,2)")]
        public decimal ValorFinal { get; set; }
        public DateTime DataPedido { get; set; } = DateTime.Now;
    }

    public static class PedidoAPI
    {
        public const string AddPedido = "AddPedido";
        public const string BuscarPedidos = "BuscarPedidos";
    }
}
