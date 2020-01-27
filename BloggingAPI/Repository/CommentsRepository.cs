using BloggingAPI.Model;
using BloggingAPI.Repository.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloggingAPI.Repository
{
    public class CommentsRepository : ICommentsRepository
    {
        private readonly BlogContext _context;
        private DbSet<Comments> _entities;
        public CommentsRepository(BlogContext context)
        {
            _context = context;
        }
        public async Task<long> AddAsync(Comments obj)
        {
            await this.Entities.AddAsync(obj);
            return await _context.SaveChangesAsync();
        }
        private DbSet<Comments> Entities
        {
            get
            {
                if (_entities == null)
                {
                    _entities = _context.Set<Comments>();
                }
                return _entities;
            }
        }
    }
}
