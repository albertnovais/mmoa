using FluentValidator;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace mmoa.domain.Commands.Person.AddPerson
{
    public class AddPersonHandle : Notifiable, IRequestHandler<AddPersonRequest, Response>
    {
        public Task<Response> Handle(AddPersonRequest request, CancellationToken cancellationToken)
        {
            var person = new Entities.Person(request.Name, request.EmailAddress, request.Password);

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
                result = new Response(Valid, "ok", null);

            return Task.FromResult(result);

        }
    }
}
