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
    public class LoginRepository : ILoginRepository
    {
        private readonly BlogContext _context;
        private DbSet<UserDetails> _entities;
        public LoginRepository(BlogContext context)
        {
            _context = context;
        }
        public async Task<UserDetails> Login(string userName, string password)
        {
            try
            {
                //var user = _context.userDetails.Where(x => x.username.Equals(userName) & x.password.Equals(password)).FirstOrDefault();
                //var user = _context.userDetails.
                //return await this.Entities.Include(x => x.username).FirstOrDefaultAsync(e => e.username == userName & e.password == password);

                var user = await (from userDetails in _context.userDetails
                                      where userDetails.username==userName && userDetails.password == password
                                      select new UserDetails
                                      {
                                          id = userDetails.id,
                                          username = userDetails.username,
                                          password = userDetails.password
                                      }).FirstOrDefaultAsync();
                return user;
            }
            catch(Exception ex)
            {

            }
            return await Task.FromResult(new UserDetails());
        }
        private DbSet<UserDetails> Entities
        {
            get
            {
                if (_entities == null)
                {
                    _entities = _context.Set<UserDetails>();
                }
                return _entities;
            }
        }
    }
}
