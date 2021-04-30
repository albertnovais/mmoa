using mmoa.Domain.Entities.Base;

namespace mmoa.Domain.Entities
{
    public class BudgetItem: EntityBase
    {
        public Budget Budget { get; private set; }

        public BudgetStandardItem BudgetStandardItem { get; private set; }

        public decimal Value { get; private set; }
    }
}
