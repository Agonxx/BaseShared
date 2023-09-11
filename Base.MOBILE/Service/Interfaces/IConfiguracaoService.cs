using Base.MOBILE.Service.Interfaces;
using Base.Shared.Models;

namespace Base.MOBILE.Service
{
    public interface IConfiguracaoService : IBaseService<Configuracao>
    {
        public Task<Configuracao> SalvarConfiguracao(Configuracao configuracaoObj);
        public Task<Configuracao> BuscarConfiguracao();
    }
}