using Base.API.Data;
using Base.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Base.API.Repository
{
    public class ConfiguracaoRepository
    {
        private BaseContext _db;

        public ConfiguracaoRepository(BaseContext context)
        {
            _db = context;
        }

        public async Task<Configuracao> SalvarConfiguracao(Configuracao configuracaoObj)
        {
            _db.Configuracoes.Update(configuracaoObj);
            await _db.SaveChangesAsync();
            return configuracaoObj;
        }

        public async Task<Configuracao> BuscarConfiguracao()
        {
            var config = await _db.Configuracoes.FirstOrDefaultAsync();

            return config;
        }
    }
}
