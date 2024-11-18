using Flunt.Notifications;
using Flunt.Validations;

namespace Domain.Entities
{
    public class Veiculos : Notifiable 
    {
        public Veiculos(string placaVeiculo)
        {
            PlacaVeiculo = placaVeiculo;
            HoraEntrada = DateTime.Now;

            AddNotifications(new Contract()
                .Requires()
                .IsNotNullOrEmpty(placaVeiculo, "Veiculos.PlacaVeiculo", "Campo não pode ser vazio")
                .HasLen(placaVeiculo, 7, "Veiculos.PlacaVeiculo", "Placa Inválida (Deve conter 7 caracteres) ")
                );
                
        }
        public string PlacaVeiculo { get; private set; }
        public DateTime HoraEntrada { get; private set; }
    }


}
