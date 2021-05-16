using MediatR;
using System.Threading;
using System.Threading.Tasks;
using mmoa.Domain.Extencions;
using mmoa.Domain.Interfaces.Repositories;
using FluentValidator;

namespace mmoa.Domain.Commands.User.AutenticarUser
{
    public class AutenticarUserHandler : Notifiable, IRequestHandler<AutenticarUserResquest, AutenticarUserResponse>
    {
        private readonly IMediator _mediator;
        private readonly IRepositoryUser _repositoryUser;

        public AutenticarUserHandler(IMediator mediator, IRepositoryUser RepositoryUser)
        {
            _mediator = mediator;
            _repositoryUser = RepositoryUser;
        }

        public async Task<AutenticarUserResponse> Handle(AutenticarUserResquest request, CancellationToken cancellationToken)
        {
            //Valida se o objeto request esta nulo
            if (request == null)
            {
                AddNotification("Request", "Campo Obrigatório");
                return null;
            }

            request.Pass = request.Pass.ConvertToMD5();

            mmoa.Domain.Entities.User user = _repositoryUser.GetBy(x => x.EmailAddress == request.Email && x.Password == request.Pass);

            if (user == null)
            {
                AddNotification("Usuario","Usuario Não Informado");
                return new AutenticarUserResponse()
                {
                    IsAuthenticad = false
                };
            }

            //Cria objeto de resposta
            var response = (AutenticarUserResponse)user;

            ////Retorna o resultado
            return await Task.FromResult(response);
        }
    }
}

