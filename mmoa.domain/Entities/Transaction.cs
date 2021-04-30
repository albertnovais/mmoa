using mmoa.Domain.Entities.Base;

namespace mmoa.domain.Entities
{
    public class Transaction:EntityBase
    {
        public Transaction()
        {
        }

        public Transaction(string description, decimal value, bool isSameHolder, bool isEntry, Institution institution, Institution originInstitution)
        {
            Description = description;
            Value = value;
            IsSameHolder = isSameHolder;
            IsEntry = isEntry;
            Institution = institution;
            OriginInstitution = originInstitution;
        }

        public string Description { get; set; }

        public decimal Value { get; private set; }

        public bool IsSameHolder  { get; private set; }

        public bool IsEntry { get; private set; }

        public Institution Institution { get; private set; }

        public Institution? OriginInstitution { get; private set; }
     
    }
}
