using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Base.Shared.Models
{
    public class Sabor
    {
        [Key]
        public int Id { get; set; }
        public string DescricaoSabor { get; set; }
    }

    public static class SaborAPI
    {
        public const string CadastrarSabor = "CadastrarSabor";
        public const string CadastrarListaSabores = "CadastrarListaSabores";
        public const string BuscarListaSabores = "BuscarListaSabores";
    }
}
