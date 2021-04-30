using System;
using System.Collections.Generic;
using System.Text;

namespace mmoa.domain.Commands.Person.AddPerson
{
    public class AddPersonRequest
    {
        public string Name { get; set; }

        public string EmailAddress { get; set; }

        public string Password { get; set; }
    }
}
