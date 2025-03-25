using Domain.Enums;

namespace ParkingApi.Models.Requests
{
    public class AdicionarVeiculoRequest
    {
        public string Placa { get; set; }
        public EVeiculoType TipoVeiculo { get; set; }
    }
}
