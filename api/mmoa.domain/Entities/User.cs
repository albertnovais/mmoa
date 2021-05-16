using FluentValidator.Validation;
using mmoa.Domain.Entities.Base;
using mmoa.Domain.Extencions;
using System;

namespace mmoa.Domain.Entities
{
    public class User :EntityBase
    {
        public User()
        {
        } 
        
        public User(Guid id)
        {
            Id = id;
        }

        public User(string name, string emailAddress, string password)
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
            IsActive = true;

            CreateDate = DateTime.Now;
        }       

        public string EmailAddress { get; private set; }
        public string Password { get; private set; }
        public bool IsActive { get; private set; }
        public string Name { get; private set; }
        public string PersonCode { get; private set; }
        public DateTime CreateDate { get; set; }

    }
}
