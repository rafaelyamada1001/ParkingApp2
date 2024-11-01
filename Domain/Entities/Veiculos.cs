namespace Domain.Entities
{
    public class Veiculos
    {
        public Veiculos(string placaVeiculo, DateTime horaEntrada)
        {
            PlacaVeiculo = placaVeiculo;
            HoraEntrada = horaEntrada;
        }

        public string PlacaVeiculo { get; set; }
        public DateTime HoraEntrada { get; set; }
    }
}
