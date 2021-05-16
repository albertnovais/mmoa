using mmoa.Domain.Entities.Base;
using mmoa.Domain.Enums;

namespace mmoa.Domain.Entities
{
    public class Institution : EntityBase
    {
        public Institution()
        {
        }       

        public Institution(string name, InstitutionType institutionType)
        {
            Name = name;
            InstitutionType = institutionType;
        }

        public string Name { get; private set; }
        public InstitutionType InstitutionType{ get; private set; }
    }
}
