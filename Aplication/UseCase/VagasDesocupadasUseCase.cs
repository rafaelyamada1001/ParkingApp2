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
        public void ExecuteVagasLivres()
        {
            var teste = _estacionamentoRepository.VagasTotais();
            int vagasOcupadas = _estacionamentoRepository.VagasOcupadas();

            int vagasTotais = teste.VagasTotais;
            var vagasLivres = vagasTotais - vagasOcupadas;
            
        }
    }
}
