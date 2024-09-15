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
        private readonly ILoginRepository _loginRepository;

        public LoginService(ILoginRepository loginRepository)
        {
                _loginRepository = loginRepository;
        }
        public async Task teste()
        {
             await _loginRepository.Create(new Domain.Entidades.User() { Ativo= true, Nome= "Davi", Email="davi@123", Senha="123", Created_At = DateTime.Now, Updated_At = DateTime.Now});
            
        }
    }
}
