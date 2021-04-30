using FluentValidator;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using mmoa.Domain.Interfaces.Repositories;

namespace mmoa.Domain.Commands.Person.AddPerson
{
    public class AddPersonHandle : Notifiable, IRequestHandler<AddPersonRequest, Response>
    {

        private readonly IRepositoryPerson repositoryPerson;

        public AddPersonHandle(IRepositoryPerson repositoryPerson)
        {
            this.repositoryPerson = repositoryPerson;
        }

        public Task<Response> Handle(AddPersonRequest request, CancellationToken cancellationToken)
        {
            var person = new Entities.Person(request.Name);

            return Verify(person);

        }


        private Task<Response> Verify(Entities.Person person)
        {
            AddNotifications(person.Notifications);

            Response result;

            if (Invalid)
            {
                result = new Response(Valid, "Valide os campos enviados", Notifications);
                return Task.FromResult(result);
            }

            repositoryPerson.Add(person);
            result = new Response(Valid, "ok", person);

            return Task.FromResult(result);

        }
    }
}
