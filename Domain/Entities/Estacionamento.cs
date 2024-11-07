using MySql.Data.MySqlClient;

namespace Domain.Entities
{
    public class Estacionamento
    {
        public Estacionamento(int vagas, decimal valor)
        {          
            Vagas = vagas;
            this.valor = valor;
        }

        public int Vagas { get; set; }
        private decimal valor { get; set; }
    }
}
