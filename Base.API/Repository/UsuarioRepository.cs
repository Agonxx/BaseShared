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

        public async Task<Usuario> CadastrarUsuario(Usuario usuario)
        {
            await _db.Usuarios.AddAsync(usuario);
            await _db.SaveChangesAsync();
            return usuario;
        }

        public async Task<Usuario> AddUsuario()
        {
            var user = new Usuario
            {
                Nome = "Rafael",
                Apelido = "Agon",
                Email = "Rafhita1@gmail.com"
            };

            await _db.Usuarios.AddAsync(user);
            await _db.SaveChangesAsync();
            return user;
        }

        public async Task<List<Usuario>> BuscarUsuarios()
        {
            var usuarios = await _db.Usuarios.ToListAsync();
            return usuarios;
        }
    }
}
