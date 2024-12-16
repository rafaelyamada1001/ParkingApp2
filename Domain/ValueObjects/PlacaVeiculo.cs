using Domain.Notifications;
using Domain.Validations;
using Domain.Validations.Interfaces;


namespace Domain.ValueObjects
{
    public class PlacaVeiculo : IValidations, IContract
    {
        private List<Notification> _notifications;
        public PlacaVeiculo(string placa)
        {
            Placa = placa;
            _notifications = new List<Notification>();
        }

        public string Placa { get; private set; }

        public IReadOnlyCollection<Notification> Notifications => _notifications;

        protected void SetNotificationsList(List<Notification> notifications)
        {
            _notifications = notifications;
        }

        public bool Validation()
        {

            var contracts = new ContractValidations<PlacaVeiculo>()
                .PlacaIsOk(Placa, "Formato inválido! Placa deve seguir padrões brasileiro ou mercosul", "Placa Veículo");

            _notifications.AddRange(contracts.Notifications);

            return contracts.IsValid();
        }
    }
}
