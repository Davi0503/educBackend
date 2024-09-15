using Domain.Entidades;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface IUserService
    {
        Task<List<User>> GetAllUsers();

        Task<User> GetUserByID(int Id);

        Task CreateUser(UserModel user);

        Task UpdateUser(User user);

        Task DeleteUser(int Id);

    }
}
