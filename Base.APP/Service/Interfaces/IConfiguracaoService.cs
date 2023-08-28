using Base.APP.Service.Interfaces;
using Base.Shared.Models;

namespace Base.APP.Service
{
    public interface IConfiguracaoService : IBaseService<Configuracao>
    {
        public Task<Configuracao> SalvarConfiguracao(Configuracao configuracaoObj);
        public Task<Configuracao> BuscarConfiguracao();
    }
}