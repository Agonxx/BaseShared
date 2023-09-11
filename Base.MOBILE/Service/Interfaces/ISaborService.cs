
using Base.MOBILE.Service.Interfaces;
using Base.Shared.Models;

namespace Base.MOBILE.Service
{
    public interface ISaborService : IBaseService<Sabor>
    {
        public Task<List<string>> BuscarListaSabores();
    }
}
