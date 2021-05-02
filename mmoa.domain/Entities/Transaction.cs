using mmoa.Domain.Entities;
using mmoa.Domain.Entities.Base;

namespace mmoa.Domain.Entities
{
    public class Transaction:EntityBase
    {
        public Transaction()
        {
        }

        public Transaction(bool isSameHolder, bool isEntry, Institution institution, Person person)
        {
            IsSameHolder = isSameHolder;
            IsEntry = isEntry;
            Institution = institution;
            Person = person;
        }

        public bool IsSameHolder  { get; private set; }

        public bool IsEntry { get; private set; }

        public Institution Institution { get; private set; }

        public Person Person { get; private set; }

    }
}
