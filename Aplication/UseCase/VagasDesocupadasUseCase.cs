using Aplication.DTO;
using Aplication.Interface;


namespace Aplication.UseCase
{
    public class VagasDesocupadasUseCase
    {
        private readonly IEstacionamentoRepository _estacionamentoRepository;

        public VagasDesocupadasUseCase(IEstacionamentoRepository estacionamentoRepository)
        {
           _estacionamentoRepository = estacionamentoRepository;
        }

        public ResponseDefault<TipoVagasDTO> Execute()
        {
            var vagasTotaisDTO = _estacionamentoRepository.VagasTotais();
            var vagasOcupadas = _estacionamentoRepository.VagasOcupadas();

            if (!vagasTotaisDTO.Sucesso) return new ResponseDefault<TipoVagasDTO>(false, vagasTotaisDTO.Mensagem, null);
            if (!vagasOcupadas.Sucesso) return new ResponseDefault<TipoVagasDTO>(false, vagasOcupadas.Mensagem, null);

            var vagasTotaisCarros = vagasTotaisDTO.Dados.TotalVagasCarros;
            var vagasTotaisMotos = vagasTotaisDTO.Dados.TotalVagasMotos;
            var vagasLivresCarro = vagasTotaisCarros - vagasOcupadas.Dados.VagasCarros;
            var vagasLivresMoto = vagasTotaisMotos - vagasOcupadas.Dados.VagasMotos;

            var dtoVagasLivres = new TipoVagasDTO(vagasLivresCarro, vagasLivresMoto);
            
             return new ResponseDefault<TipoVagasDTO>(true, "OK", dtoVagasLivres );
        }
    }
}
