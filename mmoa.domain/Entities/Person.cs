using FluentValidator.Validation;
using mmoa.Domain.Entities.Base;
using System;

namespace mmoa.Domain.Entities
{
    public class Person :EntityBase
    {
        public Person()
        {
        } 
        
        public Person(Guid id)
        {
            Id = id;
        }

        public Person(string name)
        {
            Name = name;

            AddNotifications(new ValidationContract()
                                 .HasMinLen(Name, 3, "Name", "A propiedade nome deve ter pelo menos 3 caracteres")
                                 .HasMaxLen(Name, 150, "Name", "A propiedade nome deve ter menos que 150 caracteres"));
                               

            CreateDate = DateTime.Now;
        }

        public string Name { get; private set; }
        public string PersonCode { get; private set; }
        public DateTime CreateDate { get; set; }
    }
}
