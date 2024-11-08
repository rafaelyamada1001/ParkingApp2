
namespace Aplication.DTO
{
    public class VeiculosDTO
    {
        public string Placa { get; set; }
        public DateTime HoraEntrada { get; set; }

        public VeiculosDTO(string placa, DateTime horaEntrada)
        {
            Placa = placa;
            HoraEntrada = horaEntrada;
        }
    }
}
