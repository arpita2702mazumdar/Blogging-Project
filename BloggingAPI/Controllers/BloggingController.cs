using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BloggingAPI.Contracts;
using BloggingAPI.DTO;
using Microsoft.AspNetCore.Mvc;

namespace BloggingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BloggingController : ControllerBase
    {
        private readonly IBlogService _blogService;
        private readonly ICommentsService _commentService;
        private readonly ILoginService _loginService;

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }
        public BloggingController(IBlogService blogService,
            ICommentsService commentService,
            ILoginService loginService)
        {
            _blogService = blogService;
            _commentService = commentService;
            _loginService = loginService;
        }
        [HttpGet]
        [Route("Login")]
        public async Task<User> Login(string username, string password)
        {
            return await _loginService.GetUser(username, password);
        }
        [HttpGet]
        [Route("GetBlogs")]
        public async Task<List<BlogsModel>> GetBlogs()
        {
            return await _blogService.GetBlogs();
        }
        [HttpPost]
        [Route("SaveBlog")]
        public async Task<long> SaveBlog(BlogSave obj)
        {
            return await _blogService.AddAsync(obj);
        }
        [HttpPost]
        [Route("SaveComment")]
        public async Task<long> SaveComment(CommentsModel obj)
        {
            return await _commentService.AddAsync(obj);
        }

    }
}