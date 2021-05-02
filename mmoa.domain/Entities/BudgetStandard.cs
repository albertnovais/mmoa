using mmoa.Domain.Entities.Base;
using mmoa.Domain.Enums;

namespace mmoa.Domain.Entities
{
    public class BudgetStandard: EntityBase
    {
        public decimal Weight { get; private set; }

        public BudgetStandardType BudgetStandardType { get; private set; }

        public BudgetStandardGroup BudgetStandardGroup { get; set; }

        public Budget Budget { get; private set; }

    }
}
