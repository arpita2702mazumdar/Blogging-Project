using BloggingAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloggingAPI.Repository.Contracts
{
    public interface ICommentsRepository
    {
        Task<long> AddAsync(Comments obj);
    }
}
