using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Domain.Models.User.Get;
using TestTask.Domain.Models.User.Login;
using TestTask.Domain.Models.User.Register;

namespace TestTask.Application.Interfaces
{
    public interface IUserService
    {
        Task<RegisterResponse> Register(RegisterRequest request);
        Task<LoginResponse> Login(LoginRequest request);
        Task<List<GetResponse>> Get();
        Task<GetResponse> GetMe();
    }
}
