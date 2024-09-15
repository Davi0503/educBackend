using Domain.Entidades;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Mapping
{
    public class UserMap
    {

        public static User ModelCreateMap(UserModel model)
        {
            return new User()
            {
                Email = model.Email,
                Senha = model.Senha,
                Nome = model.Nome,
                Ativo = true,
                Created_At = DateTime.Now,
                Updated_At = DateTime.Now,
            };
        }

    }
}
