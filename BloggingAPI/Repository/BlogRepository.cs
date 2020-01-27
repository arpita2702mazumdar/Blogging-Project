using AutoMapper;
using BloggingAPI.DTO;
using BloggingAPI.Model;
using BloggingAPI.Repository.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloggingAPI.Repository
{
    public class BlogRepository : IBlogRepository
    {
        private readonly BlogContext _context;
        private IMapper _mapper;
        private DbSet<Blogmodel> _entities;
        public BlogRepository(BlogContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<long> AddAsync(Blogmodel obj)
        {
            await this.Entities.AddAsync(obj);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<BlogsModel>> GetBlogs()
        {
            try
            {
                var blogList = await (from blogs in _context.blogs
                                      join comments in _context.comments on blogs.id equals comments.blogId
                                      select new BlogsModel
                                      {
                                          id = blogs.id,
                                          userId = blogs.userId,
                                          blogContent = blogs.blogContent,
                                          comments = blogs.comments
                                      }).ToListAsync();
                return blogList;
            }
            catch(Exception ex)
            {

            }
            return null;
        }
        private DbSet<Blogmodel> Entities
        {
            get
            {
                if (_entities == null)
                {
                    _entities = _context.Set<Blogmodel>();
                }
                return _entities;
            }
        }
    }
}
