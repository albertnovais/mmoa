using mmoa.Domain.Entities.Base;

namespace mmoa.Domain.Entities
{
    public class BudgetStandardItem: EntityBase
    {
        public string Name { get; set; }

        public string Description { get; private set; }
    }
}
