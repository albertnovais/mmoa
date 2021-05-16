using mmoa.Infra.Repositories.Base;

namespace mmoa.Infra.Repositories.Transactions
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MmoaContext _context;

        public UnitOfWork(MmoaContext context)
        {
            _context = context;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
