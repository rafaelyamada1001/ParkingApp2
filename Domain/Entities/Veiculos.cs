using Domain.Enums;
using Domain.Notifications;
using Domain.ValueObjects;

namespace Domain.Entities
{
    public class Veiculos : BaseEntity
    {
        private List<Notification> _notifications;

        public Veiculos(PlacaVeiculo placa, EVeiculoType tipoVeiculo)
        {
            Placa = placa;
            HoraEntrada = DateTime.Now;
            TipoVeiculo = tipoVeiculo;
            _notifications = new List<Notification>();
        }

        public PlacaVeiculo Placa { get; private set; }
        public EVeiculoType TipoVeiculo { get; private set; }
        public DateTime HoraEntrada { get; private set; }

        public IReadOnlyCollection<Notification> Notifications => _notifications;

        protected void SetNotificationsList(List<Notification> notifications)
        {
            _notifications = notifications;
        }

        public override bool Validation()
        {
            return Placa.Validation();
        }
    }
}
