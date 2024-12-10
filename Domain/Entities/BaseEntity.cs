using Domain.Validations.Interfaces;
using Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Notifications;

namespace Domain.Entities
    {
        public class Veiculo : IValidations, IContract
        {
            private List<Notification> _notifications;

            public Veiculo(string placaVeiculo)
            {
                PlacaVeiculo = placaVeiculo;
                HoraEntrada = DateTime.Now;
            }

            public string PlacaVeiculo { get; private set; }
            public DateTime HoraEntrada { get; private set; }


            public IReadOnlyCollection<Notification> Notifications => _notifications;


            protected void SetNotificationsList(List<Notification> notifications)
            {
                _notifications = notifications;
            }

            public bool Validation()
            {
                var contracts = new ContractValidations<Veiculos>()
                    .PlacaIsOk(this.PlacaVeiculo, 7, 7, "A Placa não pode ser nula ou deve conter 7 caracteres", "Placa Veículo");


                return contracts.IsValid();
            }
        }
    }
}
}
