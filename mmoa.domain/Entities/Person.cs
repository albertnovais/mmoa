using FluentValidator.Validation;
using mmoa.domain.Entities.Base;
using System;
using mmoa.Domain.Extencions;

namespace mmoa.domain.Entities
{
    public class Person :EntityBase
    {
        public Person(string name, string emailAddress, string password)
        {
            Name = name;
            EmailAddress = emailAddress;
            Password = password;

            AddNotifications(new ValidationContract()
                                 .HasMinLen(Name, 3, "Name", "A propiedade nome deve ter pelo menos 3 caracteres")
                                 .HasMaxLen(Name, 150, "Name", "A propiedade nome deve ter menos que 150 caracteres")
                                 .IsEmail(EmailAddress, "EmailAddress", "Este Email não é valido")
                                 .HasMinLen(Password, 8, "Password", "A propiedade Password deve ter pelo menos 8 caracteres")
                                 .HasMaxLen(Password, 32, "Password", "A propiedade Password deve ter menos que 32 caracteres"));

            if (!string.IsNullOrEmpty(this.Password))
            {
                this.Password = Password.ConvertToMD5();
            }

            CreateDate = DateTime.Now;
            IsActive = false;

        }

        public string Name { get; private set; }

        public string EmailAddress { get; private set; }

        public string Password { get; private set; }

        public bool IsActive { get; private set; }

        public DateTime CreateDate { get; set; }
    }
}
