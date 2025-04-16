using Aplication.DTO;
using Aplication.Interface;
using Domain.Entities;

namespace Aplication.UseCase
{
    public class CadastrarClienteUseCase
    {
        private readonly IClienteRepository _clienteRepository;
        public CadastrarClienteUseCase(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public ResponseDefault<string> Execute(CadastrarClienteRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Nome))
                 new ResponseDefault<string>(false ,"Nome é obrigatório.", null);

            if (string.IsNullOrWhiteSpace(request.Sobrenome))
                 new ResponseDefault<string>(false, "Sobrenome é obrigatório.", null);

            if (_clienteRepository.VerificarCpf(request.CpfCnpj))
                 new ResponseDefault<string>(false, "CPF/CNPJ já cadastrado.", null);

            var cliente = new Cliente(
                  request.Nome,
                  request.Sobrenome,
                  request.CpfCnpj,
                  request.Telefone
            );

            _clienteRepository.Cadastrar(cliente);

            return new ResponseDefault<string>(true, "Cliente cadastrado com sucesso!", null);
        }
    }
}
