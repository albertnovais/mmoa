using mmoa.Domain.Entities.Base;

namespace mmoa.Domain.Entities
{
    public class BudgetItem: EntityBase
    {
        public BudgetStandard BudgetStandard { get; private set; }

        public string Name { get; private set; }
    }
}
