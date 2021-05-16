using System;

namespace mmoa.Domain.Commands.User.AutenticarUser
{
    public class AutenticarUserResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsAuthenticad { get; set; }

        public static explicit operator AutenticarUserResponse(Entities.User user)
        {
            return new AutenticarUserResponse
            {
                IsAuthenticad = true,
                Id = user.Id,
                Name = user.Name
            };
        }
    }
}