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

            var vagasTotais = vagasTotaisDTO.Dados.VagasTotais;
            var vagasLivres = vagasTotais - vagasOcupadas.Dados;
            
             return new ResponseDefault<int>(true, "OK", vagasLivres);
        }
    }
}
