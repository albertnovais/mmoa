using mmoa.Domain.Entities;
using mmoa.Domain.Entities.Base;

namespace mmoa.Domain.Entities
{
    public class Transaction:EntityBase
    {
        public Transaction()
        {
        }

        public Transaction(bool isSameHolder, bool isEntry, Institution institution, User user)
        {
            IsSameHolder = isSameHolder;
            IsEntry = isEntry;
            Institution = institution;
            User = user;
        }

        public bool IsSameHolder  { get; private set; }

        public bool IsEntry { get; private set; }

        public Institution Institution { get; private set; }

        public User User { get; private set; }

    }
}
