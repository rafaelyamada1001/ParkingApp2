using Domain.Notifications;
using System.Text.RegularExpressions;

namespace Domain.Validations
{
    public partial class ContractValidations<T>
    {
        public ContractValidations<T> PlacaIsOk(string placaVeiculo, string message, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(placaVeiculo))
            {
                AddNotification(new Notification(message, propertyName));
            }

            string padrao = @"^[A-Z]{3}[0-9]{4}$|^[A-Z]{3}[0-9][A-Z][0-9]{2}$";

            if (!Regex.IsMatch(placaVeiculo, padrao, RegexOptions.IgnoreCase))
            {
                AddNotification(new Notification(message, propertyName));
            }

            return this;
        }
    }

}
