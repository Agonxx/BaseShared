
using Base.APP.Service.Interfaces;
using Base.Shared.Models;

namespace Base.APP.Service
{
    public interface ISaborService : IBaseService<Sabor>
    {
        public Task<List<string>> BuscarListaSabores();
    }
}
