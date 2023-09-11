using Base.MOBILE.Service.Interfaces;
using Base.Shared.Models;

namespace Base.MOBILE.Service
{
    public interface IUsuarioService : IBaseService<Usuario>
    {
        public Task<Usuario> AddUsuario();
        public Task<Usuario> CadastrarUsuario(Usuario usuaroObj);
        public Task<List<Usuario>> BuscarUsuarios();
    }
}
