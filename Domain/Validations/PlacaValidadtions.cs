using Domain.Entities;

namespace Domain.Validations
{
    public partial class ContractValidations<T>
    {
        public  ContractValidations<T> PlacaIsOk(string placaVeiculo, short maxLength, short minLength, string message, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(placaVeiculo))
            {
                throw new ArgumentException(message, propertyName);
            }

            if (placaVeiculo.Length > maxLength || placaVeiculo.Length < minLength)
            {
                throw new ArgumentException(message, propertyName);
            }

            return this;
        }
    }

}
