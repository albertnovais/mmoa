using System;
using mmoa.Domain.Entities;
using mmoa.Domain.Interfaces.Repositories;
using mmoa.Infra.Repositories.Base;

namespace mmoa.Infra.Repositories
{
    public class RespositoryUser : RepositoryBase<User, Guid>, IRepositoryUser
    {
        private readonly MmoaContext _context;
        public RespositoryUser(MmoaContext context) : base(context)
        {
            _context = context;
        }
    }

}
