namespace Domain.ValueObjects
{
    public class PlacaVeiculo
    {
        public PlacaVeiculo(string placa)
        {
            Placa = placa;
        }

        public string Placa { get; private set; }
    }
}
