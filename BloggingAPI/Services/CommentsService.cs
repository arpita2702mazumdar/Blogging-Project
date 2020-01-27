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
    public class CommentsService : ICommentsService
    {
        private ICommentsRepository _repository;
        public CommentsService(ICommentsRepository repository)
        {
            _repository = repository;
        }
        public async Task<long> AddAsync(CommentsModel obj)
        {
            Comments comment = new Comments()
            {
                userId = obj.userId,
                blogId = obj.blogId,
                commentContent = obj.commentContent
            };
            return await _repository.AddAsync(comment);
        }
    }
}
