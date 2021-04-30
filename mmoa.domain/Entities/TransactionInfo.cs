using mmoa.Domain.Entities;
using mmoa.Domain.Entities.Base;
using mmoa.Domain.Enums;
using System;
using System.Collections.Generic;

namespace mmoa.domain.Entities
{
    public class TransactionInfo:EntityBase
    {
        public TransactionInfo()
        {
        }

        public TransactionInfo(string description, decimal value, TransactionType transactionType)
        {
            Description = description;
            Value = value;
            TransactionType = transactionType;
            CreateDate = DateTime.Now;
            Transaction = Transaction;
        }

        public string Description { get; set; }
        public decimal Value { get; private set; }        
        public TransactionType TransactionType { get; private set; }
        public DateTime CreateDate { get; private set; }
        public List<Transaction> Transaction { get; set; }
    }
}
