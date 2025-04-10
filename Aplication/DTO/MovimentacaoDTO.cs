namespace Aplication.DTO
{
    public class MovimentacaoDTO
    {
        public string Placa {  get; set; }
        public string TipoVeiculo { get; set; }
        public DateTime HoraEntrada { get; set; }
        public DateTime HoraSaida { get; set; }
        public string PermanenciaHora { get; set; }
        public string PermanenciaMin {  get; set; }
        public string Valor {  get; set; }
    }
}
