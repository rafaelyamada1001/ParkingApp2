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

        public int Execute()
        {
            var vagasTotaisDTO = _estacionamentoRepository.VagasTotais();
            var vagasOcupadas = _estacionamentoRepository.VagasOcupadas();

            var vagasTotais = vagasTotaisDTO.Dados.VagasTotais;
            var vagasLivres = vagasTotais - vagasOcupadas;
            
            return vagasLivres;
        }
    }
}
