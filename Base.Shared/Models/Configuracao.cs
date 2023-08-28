using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Base.Shared.Models
{
    public class Configuracao
    {
        [Key]
        public int Id { get; set; } = 1;
        public string NomePix { get; set; } = "Rafael";
        public string CidadePix { get; set; } = "Rio Claro";
        public string ChavePix { get; set; } = "rafhita1@gmail.com";
        [Column(TypeName = "decimal(18,2)")]
        public decimal ValorPequeno { get; set; } = 10m;
        [Column(TypeName = "decimal(18,2)")]
        public decimal ValorMedio { get; set; } = 15m;
        [Column(TypeName = "decimal(18,2)")]
        public decimal ValorGrande { get; set; } = 120m;
        [Column(TypeName = "decimal(18,2)")]
        public decimal ValorAdicional { get; set; } = 1.5m;
        [Column(TypeName = "decimal(18,2)")]
        public decimal ValorEntrega { get; set; } = 7m;

    }

    public static class ConfiguracaoAPI
    {
        public const string SalvarConfiguracao = "SalvarConfiguracao";
        public const string BuscarConfiguracao = "BuscarConfiguracao";
    }
}
