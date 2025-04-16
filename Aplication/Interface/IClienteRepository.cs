using Aplication.DTO;
using Domain.Entities;

namespace Aplication.Interface
{
    public interface IClienteRepository
    {
        ResponseDefault<string> Cadastrar(Cliente cliente);
        ResponseDefault<List<Cliente>> ListarClientes();
        bool VerificarCpf(string cpf);
    }
}
