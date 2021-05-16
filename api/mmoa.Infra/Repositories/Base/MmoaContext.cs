using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mmoa.Domain.Entities;
using mmoa.Infra.Repositories.Map;
using FluentValidator;

namespace mmoa.Infra.Repositories.Base
{
    public partial class MmoaContext:DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Budget> Budget { get; set; }
        public DbSet<BudgetItem> budgetItem { get; set; }
        public DbSet<BudgetStandard> BudgetStandard { get; set; }
        public DbSet<BudgetStandardGroup> BudgetStandardGroup { get; set; }
        public DbSet<Institution> Institution { get; set; }
        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<TransactionInfo> TransactionInfo { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=IATECBR-NB199;Initial Catalog=VemDeZap;Integrated Security=True");
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //ignorar classes
            modelBuilder.Ignore<Notification>();            

            //aplicar configurações
            modelBuilder.ApplyConfiguration(new MapUser());           


            base.OnModelCreating(modelBuilder);
        }
    }
}
