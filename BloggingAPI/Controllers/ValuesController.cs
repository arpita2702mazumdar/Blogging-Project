using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BloggingAPI.Contracts;
using BloggingAPI.DTO;
using BloggingAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace BloggingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //private readonly IBlogService _blogService;
        //private readonly ICommentsService _commentService;
        //private readonly ILoginService _loginService;

        //public ValuesController(IBlogService blogService, ICommentsService commentService, ILoginService loginService)
        //{
        //    _blogService = blogService;
        //    _commentService = commentService;
        //    _loginService = loginService;
        //}
        //[HttpGet]
        //[Route("Login")]
        //public async Task<User> Login(string username, string password)
        //{
        //    return await _loginService.GetUser(username, password);
        //}
        //[HttpGet]
        //[Route("GetBlogs")]
        //public async Task<List<BlogsModel>> GetBlogs()
        //{
        //    return await _blogService.GetBlogs();
        //}
        //[HttpPost]
        //[Route("SaveBlog")]
        //public async Task<long> SaveBlog(Blogs obj)
        //{
        //    return await _blogService.AddAsync(obj);
        //}
        //[HttpPost]
        //[Route("SaveComment")]
        //public async Task<long> SaveComment(Comments obj)
        //{
        //    return await _commentService.AddAsync(obj);
        //}
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
