using FluentValidator;
using MediatR;
using mmoa.Domain.Interfaces.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace mmoa.Domain.Commands.User.AddUser
{
    public class AddUserHandle : Notifiable, IRequestHandler<AddUserRequest, Response>
    {
        private readonly IRepositoryUser repositoryUser;

        public AddUserHandle(IRepositoryUser repositoryUser)
        {
            this.repositoryUser = repositoryUser;
        }

        public Task<Response> Handle(AddUserRequest request, CancellationToken cancellationToken)
        {
            var user = new Entities.User(request.Name, request.EmailAddress,request.Password);

            return Verify(user);

        }

        private Task<Response> Verify(Entities.User user)
        {
            AddNotifications(user.Notifications);

            Response result;

            if (Invalid)
            {
                result = new Response(Valid, "Valide os campos enviados", Notifications);
                return Task.FromResult(result);
            }

            repositoryUser.Add(user);
            result = new Response(Valid, "ok", user);

            return Task.FromResult(result);

        }
    }
}
