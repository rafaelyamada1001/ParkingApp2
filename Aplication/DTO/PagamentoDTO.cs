namespace Aplication.DTO
{
    public class PagamentoDTO
    {
        public string Placa { get; set; }
        public string TipoVeiculo { get; set; }
        public DateTime HoraEntrada { get; set; }
        public DateTime HoraSaida { get; set; }
        public TimeSpan TempoEstacionado { get; set; }
        public int HorasCobradas { get; set; }
        public decimal ValorTotal { get; set; }

        // Propriedade de leitura útil para exibição formatada
        public string TempoFormatado => $"{(int)TempoEstacionado.TotalHours}h {TempoEstacionado.Minutes}min";
    }
}


