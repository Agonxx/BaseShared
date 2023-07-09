using Base.API.Data;
using Base.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Base.API.Repository
{
    public class UsuarioRepository
    {
        private BaseContext _db;

        public UsuarioRepository(BaseContext context)
        {
            _db = context;
        }

        public Usuario CadastrarUsuario(Usuario usuario)
        {
            _db.Usuarios.Add(usuario);
            _db.SaveChanges();
            return usuario;
        }

        public Usuario AddUsuario()
        {
            var user = new Usuario
            {
                Nome = "Rafael",
                Apelido = "Agon",
                Email = "Rafhita1@gmail.com"
            };

            _db.Usuarios.Add(user);
            _db.SaveChanges();
            return user;
        }

        public async Task<List<Usuario>> BuscarUsuarios()
        {
            var usuarios = await _db.Usuarios.ToListAsync();
            return usuarios;
        }
    }
}
