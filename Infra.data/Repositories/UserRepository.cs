using Domain.Entidades;
using Domain.Interfaces.Repositories;
using Infra.data.Context;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.data.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly IConfiguration _configuration;

        public UserRepository(EducContext EducContext, IConfiguration configuration) : base(EducContext)
        {
            _configuration = configuration;
        }






    }
}
