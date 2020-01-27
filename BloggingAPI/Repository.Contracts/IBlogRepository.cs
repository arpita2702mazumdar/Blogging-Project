using BloggingAPI.DTO;
using BloggingAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloggingAPI.Repository.Contracts
{
    public interface IBlogRepository
    {
        Task<long> AddAsync(Blogmodel obj);
        Task<List<BlogsModel>> GetBlogs();
    }
}
