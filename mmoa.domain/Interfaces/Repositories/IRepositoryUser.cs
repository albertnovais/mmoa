﻿using System;
using mmoa.Domain.Entities;
using mmoa.Domain.Interfaces.Repositories.Base;

namespace mmoa.Domain.Interfaces.Repositories
{
    public interface IRepositoryUser : IRepositoryBase<User, Guid>
    {
    }
}
