using BloggingAPI.Contracts;
using BloggingAPI.DTO;
using BloggingAPI.Model;
using BloggingAPI.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloggingAPI.Services
{
    public class LoginService : ILoginService
    {
        private ILoginRepository _repository;
        public LoginService(ILoginRepository repository)
        {
            _repository = repository;
        }
        public async Task<User> GetUser(string username,string password)
        {
            var results= await _repository.Login(username, password);
            return new User { username = results.username, password = results.password };
        }
    }
}
