using Domain.Validations.Interfaces;
using Domain.Notifications;
using Domain.ValueObjects;

namespace Domain.Entities
{
    public abstract class BaseEntity : IValidations, IContract
    {
        private List<Notification> _notifications;

        protected BaseEntity()
        {
 
        }

        public IReadOnlyCollection<Notification> Notifications => _notifications;

        protected void SetNotificationsList(List<Notification> notifications)
        {
            _notifications = notifications;
        }

        public abstract bool Validation();

    }
}


