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

        public ResponseDefault<int> Execute()
        {
 
            var vagasTotaisDTO = _estacionamentoRepository.VagasTotais();
            var vagasOcupadas = _estacionamentoRepository.VagasOcupadas();

            if (!vagasTotaisDTO.Sucesso) return new ResponseDefault<int>(false, vagasTotaisDTO.Mensagem, 0);
            if (!vagasOcupadas.Sucesso) return new ResponseDefault<int>(false, vagasOcupadas.Mensagem, 0);

            var vagasTotaisCarros = vagasTotaisDTO.Dados.VagasTotaisCarros;
            var vagasTotaisMotos = vagasTotaisDTO.Dados.VagasTotaisMotos;
            var vagasLivresCarro = vagasTotaisCarros - vagasOcupadas.Dados.VagasCarros;
            var vagasLivresMoto = vagasTotaisMotos - vagasOcupadas.Dados.VagasMotos;
            
             return new ResponseDefault<int>(true, "OK", vagasLivresCarro );
        }
    }
}
