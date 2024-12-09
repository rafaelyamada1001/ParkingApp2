namespace Domain.Entities
{
    public class Estacionamento
    {
        public Estacionamento(int vagas, decimal valor)
        {
            Vagas = vagas;
            Valor = valor;
        }

        public int Vagas { get; private set; }
        public decimal Valor { get; private set; }
    }
}
