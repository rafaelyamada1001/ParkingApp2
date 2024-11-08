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

        public int ExecuteVagasLivres()
        {
            var vagasTotaisDTO = _estacionamentoRepository.VagasTotais();
            int vagasOcupadas = _estacionamentoRepository.VagasOcupadas();

            int vagasTotais = vagasTotaisDTO.VagasTotais;
            var vagasLivres = vagasTotais - vagasOcupadas;
            
            return vagasLivres;
        }
    }
}
