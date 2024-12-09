using Domain.Validations;
using Domain.Validations.Interfaces;
using Flunt.Notifications;
using Flunt.Validations;
namespace Domain.Entities
{
    public class Veiculos : IValidations, IContract
    {
        private readonly List<Notification> _notifications;

        public Veiculos(string placaVeiculo)
        {
            PlacaVeiculo = placaVeiculo;
            HoraEntrada = DateTime.Now;
        }

        public string PlacaVeiculo { get; private set; }
        public DateTime HoraEntrada { get; private set; }


        public IReadOnlyCollection<Notification> Notifications => _notifications;


        protected void SetNotification(string message, string propertyName)
        {
            _notifications.Add(new Notification(message, propertyName));
        }

        public bool Validation()
        {
            var contracts = new ContractValidations<Veiculos>()
                .PlacaIsOk(this.PlacaVeiculo, 7, 7, "A Placa não pode ser nula ou deve conter 7 caracteres", "Placa Veículo");

            return contracts.IsValid();
        }
    }
}
