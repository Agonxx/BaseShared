﻿using Base.APP.Service.Interfaces;
using Base.Shared.Models;

namespace Base.APP.Service
{
    public interface IUsuarioService : IBaseService<Usuario>
    {
        public Task<Usuario> AddUsuario();
        public Task<Usuario> CadastrarUsuario(Usuario usuaroObj);
        public Task<List<Usuario>> BuscarUsuarios();
    }
}
