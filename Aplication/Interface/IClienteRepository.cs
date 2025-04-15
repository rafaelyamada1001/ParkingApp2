using Domain.Entities;

namespace Aplication.Interface
{
    public interface IClienteRepository
    {
        void Cadastrar(Cliente cliente);
        bool VerificarCpf(string cpf);
    }
}
