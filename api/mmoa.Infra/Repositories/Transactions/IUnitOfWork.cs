namespace mmoa.Infra.Repositories.Transactions
{
    public interface IUnitOfWork
    {
        void SaveChanges();
    }
}
