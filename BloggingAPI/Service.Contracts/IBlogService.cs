using BloggingAPI.DTO;
using BloggingAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloggingAPI.Contracts
{
    public interface IBlogService
    {
        Task<long> AddAsync(BlogSave obj);
        Task<List<BlogsModel>> GetBlogs();
    }
}
