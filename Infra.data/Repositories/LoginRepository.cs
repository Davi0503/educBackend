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
    public class LoginRepository : GenericRepository<User>, ILoginRepository
    {

        private readonly EducContext _context;

        public LoginRepository(EducContext EducContext) : base(EducContext)
        {
            _context = EducContext;
        }

    }
}
