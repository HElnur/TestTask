using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Domain.Models.User.Login;

namespace TestTask.Application.CQRS.User.Commads.Login
{
    public class LoginUserCommand : IRequest<LoginResponse>
    {
        public LoginRequest Request { get; set; }

        public LoginUserCommand(LoginRequest request)
            => Request = request;
    }
}
