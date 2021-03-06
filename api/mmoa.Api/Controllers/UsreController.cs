using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using mmoa.Api.Security;
using mmoa.Domain.Commands.User.AddUser;
using mmoa.Infra.Repositories.Transactions;
using mmoa.Domain.Commands.User.AutenticarUser;
using mmoa.api.Security;

namespace mmoa.Api.Controllers
{
    public class UsreController : Base.ControllerBase
    {
        private readonly IMediator _mediator;     

        public UsreController(IMediator mediator, IUnitOfWork unitOfWork): base(unitOfWork)
        {
            _mediator = mediator;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("api/Usuario/Adicionar")]
        public async Task<IActionResult> Adicionar([FromBody] AddUserRequest request)
        {
            try
            {
                var response = await _mediator.Send(request, CancellationToken.None);
                return await ResponseAsync(response);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("api/Usuario/Autenticar")]
        public async Task<IActionResult> Autenticar(
           [FromBody] AutenticarUserResquest request,
           [FromServices] SigningConfigurations signingConfigurations,
           [FromServices] TokenConfigurations tokenConfigurations)
        {

            try
            {
                var autenticarUsuarioResponse = await _mediator.Send(request, CancellationToken.None);

                if (autenticarUsuarioResponse.Autenticado == true)
                {
                    var response = GerarToken(autenticarUsuarioResponse, signingConfigurations, tokenConfigurations);

                    return Ok(response);
                }

                return Ok(autenticarUsuarioResponse);

            }
            catch (System.Exception ex)
            {

                return NotFound(ex.Message);
            }
        }

        private object GerarToken(AutenticarUserResponse response, SigningConfigurations signingConfigurations, TokenConfigurations tokenConfigurations)
        {
            if (response.IsAuthenticad == true)
            {
                ClaimsIdentity identity = new ClaimsIdentity(
                    new GenericIdentity(response.Id.ToString(), "Id"),
                    new[] {
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString("N")),
                        //new Claim(JwtRegisteredClaimNames.UniqueName, response.Usuario)
                        new Claim("Usuario", JsonConvert.SerializeObject(response))
                    }
                );

                DateTime dataCriacao = DateTime.Now;
                DateTime dataExpiracao = dataCriacao + TimeSpan.FromSeconds(tokenConfigurations.Seconds);

                var handler = new JwtSecurityTokenHandler();
                var securityToken = handler.CreateToken(new SecurityTokenDescriptor
                {
                    Issuer = tokenConfigurations.Issuer,
                    Audience = tokenConfigurations.Audience,
                    SigningCredentials = signingConfigurations.SigningCredentials,
                    Subject = identity,
                    NotBefore = dataCriacao,
                    Expires = dataExpiracao
                });
                var token = handler.WriteToken(securityToken);

                return new
                {
                    authenticated = true,
                    created = dataCriacao.ToString("yyyy-MM-dd HH:mm:ss"),
                    expiration = dataExpiracao.ToString("yyyy-MM-dd HH:mm:ss"),
                    accessToken = token,
                    message = "OK",
                    Nome = response.Name
                };
            }
            else
            {
                return response;
            }
        }

    }
}
