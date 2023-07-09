using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Base.Shared.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Nome")]
        public string Nome { get; set; }
        [DisplayName("Apelido")]
        public string Apelido { get; set; }
        [DisplayName("E-mail")]
        public string Email { get; set; }

    }

    public static class UsuarioAPI
    {
        public const string CadastrarUsuario = "CadastrarUsuario";
        public const string BuscarUsuarios = "BuscarUsuarios";
        public const string AddUsuario = "AddUsuario";
    }

}
