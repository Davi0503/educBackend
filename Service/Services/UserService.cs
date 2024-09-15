using Domain.Entidades;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Domain.Mapping;
using Domain.Models;
using Service.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task CreateUser(UserModel user)
        {
            var teste  = UserValidation.ValidationCreateUserModel(user);
            var userMap = UserMap.ModelCreateMap(user);

            await _userRepository.Create(userMap);
        }

        public async Task DeleteUser(int id)
        {
            var userDelete =  await _userRepository.GetByID(id);
            userDelete.Ativo = false;
            await _userRepository.Update(userDelete);

        }

        public async  Task<List<User>> GetAllUsers()
        {
            return await _userRepository.GetAll();

        }

        public async Task<User> GetUserByID(int Id)
        {
            return await _userRepository.GetByID(Id);

        }

        public async Task UpdateUser(User user)
        {
            await _userRepository.Update(user);

        }
    }
}
