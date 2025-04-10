using Aplication.DTO;
using Aplication.Interface;

namespace Aplication.UseCase
{
    public class EditarVeiculoUseCase
    {
        private readonly IVeiculoRepository _repository;
        public EditarVeiculoUseCase(IVeiculoRepository repository)
        {
            _repository = repository;
        }

        public ResponseDefault<bool> Execute(string placaAtual, string placaNova, string tipoVeiculo)
        {
            if (string.IsNullOrWhiteSpace(placaNova))
                return new ResponseDefault<bool>(false, "A placa não pode estar vazia", false);

            if (string.IsNullOrWhiteSpace(tipoVeiculo))
                return new ResponseDefault<bool>(false, "O tipo de veículo deve ser informado", false);

            return _repository.EditarVeiculo(placaAtual, placaNova, tipoVeiculo);
        }
    }
}
