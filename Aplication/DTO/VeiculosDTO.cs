
using Domain.ValueObjects;

namespace Aplication.DTO
{
    public class VeiculosDTO
    {
        public VeiculosDTO(string placa, string tipoVeiculo, DateTime horaEntrada)
        {
            Placa = placa;
            TipoVeiculo = tipoVeiculo;
            HoraEntrada = horaEntrada;
        }

        public string Placa { get; set; }
        public string TipoVeiculo { get; set; }
        public DateTime HoraEntrada { get; set; }
    }
}
