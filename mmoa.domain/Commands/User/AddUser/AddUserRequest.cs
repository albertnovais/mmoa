using MediatR;
using System;

namespace mmoa.Domain.Commands.User.AddUser
{
    public class AddUserRequest: IRequest<Response>
    {
        public Guid PersonId{ get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
    }
}
