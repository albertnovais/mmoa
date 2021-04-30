using FluentValidator.Validation;
using mmoa.Domain.Entities;
using mmoa.Domain.Entities.Base;
using mmoa.Domain.Extencions;
using System;
using System.Collections.Generic;
using System.Text;

namespace mmoa.Domain.Entities
{
    public class User: EntityBase
    {
        public User(string emailAddress, string password, Guid personId)
        {
            EmailAddress = emailAddress;
            Password = password;
            Person = new Person(personId);            

            AddNotifications(new ValidationContract()
              .IsEmail(EmailAddress, "EmailAddress", "Este Email não é valido")
                                 .HasMinLen(Password, 8, "Password", "A propiedade Password deve ter pelo menos 8 caracteres")
                                 .HasMaxLen(Password, 32, "Password", "A propiedade Password deve ter menos que 32 caracteres"));

            if (!string.IsNullOrEmpty(this.Password))
            {
                this.Password = Password.ConvertToMD5();
            }
            IsActive = true;
        }

        public string EmailAddress { get; private set; }
        public string Password { get; private set; }
        public bool IsActive { get; private set; }
        public Person Person{ get; set; }
    }
}
