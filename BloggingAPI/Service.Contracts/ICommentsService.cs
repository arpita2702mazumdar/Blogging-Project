using BloggingAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloggingAPI.Contracts
{
    public interface ICommentsService
    {
        Task<long> AddAsync(CommentsModel obj);
    }
}
