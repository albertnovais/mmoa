using MediatR;

namespace mmoa.Domain.Commands.User.AutenticarUser
{
    public class AutenticarUserResquest: IRequest<AutenticarUserResponse>
    {
        public string Email { get; set; }
        public string Pass { get; set; }
    }
}
