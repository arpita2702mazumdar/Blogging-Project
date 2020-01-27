using BloggingAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloggingAPI.Contracts
{
    public interface ILoginService
    {
        Task<User> GetUser(string username, string password);
    }
}
