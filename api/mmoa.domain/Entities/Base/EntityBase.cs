using FluentValidator;
using System;

namespace mmoa.Domain.Entities.Base
{
    public abstract class EntityBase : Notifiable
    {
        protected EntityBase()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
