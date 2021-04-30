using System;
using mmoa.Domain.Entities;
using mmoa.Domain.Interfaces.Repositories.Base;

namespace VemDeZap.Domain.Interfaces.Repositories
{
    public interface IRepositoryPerson : IRepositoryBase<Person, Guid>
    {
    }
}
