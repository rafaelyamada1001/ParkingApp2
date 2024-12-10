using Domain.Validations;
using Domain.Validations.Interfaces;
using Domain.ValueObjects;
using Flunt.Notifications;
using Flunt.Validations;
namespace Domain.Entities
{
    public class Veiculos : IValidations, IContract
    {
        private List<Notification> _notifications;

        public Veiculos(PlacaVeiculo placa)
        {
            Placa = placa;
            HoraEntrada = DateTime.Now;
<<<<<<< HEAD
=======

            //mudar para fluent
            AddNotifications(new Contract()
                .Requires()
                .IsNotNullOrEmpty(placaVeiculo, "Veiculos.PlacaVeiculo", "Campo não pode ser vazio")
                .HasLen(placaVeiculo, 7, "Veiculos.PlacaVeiculo", "Placa Inválida (Deve conter 7 caracteres) ")
                );
                
>>>>>>> 6ae504f46bf99ef56b2e1c4f2fa5f771f909b716
        }

        public PlacaVeiculo Placa { get; private set; }
        public DateTime HoraEntrada { get; private set; }


        public IReadOnlyCollection<Notification> Notifications => _notifications;


        protected void SetNotificationsList(List<Notification> notifications)
        {
            _notifications = notifications;
        }

        public bool Validation()
        {
            var contracts = new ContractValidations<Veiculos>()
                .PlacaIsOk(this.Placa.Placa, 7, 7, "A Placa não pode ser nula ou deve conter 7 caracteres", "Placa Veículo");

            return contracts.IsValid();
        }
    }
}
