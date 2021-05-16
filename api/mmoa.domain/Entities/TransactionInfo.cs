using mmoa.Domain.Entities.Base;
using System;

namespace mmoa.Domain.Entities
{
    public class TransactionInfo:EntityBase
    {
        public TransactionInfo()
        {
        }      

        public string Description { get; set; }
        public decimal Value { get; private set; }        
        public DateTime Date { get; private set; }
        public Transaction Transaction { get; set; }
        public BudgetItem BudgetItem { get; private set; }
    }
}
