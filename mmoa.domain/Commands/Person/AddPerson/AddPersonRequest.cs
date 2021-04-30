using MediatR;

namespace mmoa.Domain.Commands.Person.AddPerson
{
    public class AddPersonRequest : IRequest<Response>
    {
        public string Name { get; set; }

        public string EmailAddress { get; set; }

        public string Password { get; set; }
    }
}
