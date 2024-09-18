using Domain.Entidades.Dtos.Login;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Infra.data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class LoginService : ILoginService
    {
        private readonly IUserRepository _userRepository;

        public LoginService(IUserRepository userRepository)
        {
                _userRepository = userRepository;
        }
        public async Task Login(LoginRequest login)
        {
             throw new NotImplementedException();
            
        }
    }
}
