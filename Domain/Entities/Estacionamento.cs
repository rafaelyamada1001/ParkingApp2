using Domain.Enums;

namespace Domain.Entities
{
    public class Estacionamento
    {
        public Estacionamento(EVagasType vagas, decimal valor)
        {
            Vagas = vagas;
            Valor = valor;
        }

        public EVagasType Vagas { get; private set; }
        public decimal Valor { get; private set; }
    }
}
