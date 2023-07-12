using Base.API.Repository;
using Base.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace Base.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController
    {
        private readonly UsuarioRepository _usuarioRepository;
        private readonly ILogger _logger;

        public UsuarioController(UsuarioRepository usuarioRepository, ILogger<Usuario> logger)
        {
            _usuarioRepository = usuarioRepository;
            _logger = logger;
        }

        [HttpPost(UsuarioAPI.CadastrarUsuario)]
        public async Task<Usuario> CadastrarUsuario(Usuario usuario)
        {
            usuario = await _usuarioRepository.CadastrarUsuario(usuario);
            return usuario;
        }

        [HttpGet(UsuarioAPI.AddUsuario)]
        public async Task<Usuario> AddUsuario()
        {
            var usuario = await _usuarioRepository.AddUsuario();
            return usuario;
        }

        [HttpGet(UsuarioAPI.BuscarUsuarios)]
        public async Task<List<Usuario>> BuscarUsuarios()
        {
            var usuarios = await _usuarioRepository.BuscarUsuarios();
            return usuarios;
        }
    }
}