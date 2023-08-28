using Base.API.Repository;
using Base.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace Base.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConfiguracaoController
    {
        private readonly ConfiguracaoRepository _configuracaoRepository;
        private readonly ILogger _logger;

        public ConfiguracaoController(ConfiguracaoRepository configuracaoRepository, ILogger<Configuracao> logger)
        {
            _configuracaoRepository = configuracaoRepository;
            _logger = logger;
        }

        [HttpPost(ConfiguracaoAPI.SalvarConfiguracao)]
        public async Task<Configuracao> SalvarConfiguracao(Configuracao configuracao)
        {
            var configuracaoObj = await _configuracaoRepository.SalvarConfiguracao(configuracao);
            return configuracaoObj;
        }

        [HttpGet(ConfiguracaoAPI.BuscarConfiguracao)]
        public async Task<Configuracao> BuscarConfiguracao()
        {
            var configuracaoObj = await _configuracaoRepository.BuscarConfiguracao();
            return configuracaoObj;
        }
    }
}