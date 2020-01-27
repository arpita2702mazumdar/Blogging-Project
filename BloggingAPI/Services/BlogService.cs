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
    public class BlogService : IBlogService
    {
        private IBlogRepository _repository;
        public BlogService(IBlogRepository repository)
        {
            _repository = repository;
        }
        public async Task<long> AddAsync(BlogSave obj)
        {
            Blogmodel blog = new Blogmodel() {
                userId = obj.userId,
                blogContent = obj.blogContent
            };
            return await _repository.AddAsync(blog);
        }

        public async Task<List<BlogsModel>> GetBlogs()
        {
            return await _repository.GetBlogs();
        }
    }
}
