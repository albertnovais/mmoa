using MediatR;

namespace mmoa.Domain.Commands.Person.AddPerson
{
    public class AddPersonRequest : IRequest<Response>
    {
        public string Name { get; set; }
       
    }
}
