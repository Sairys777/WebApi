using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using WebApi.DataAccessLayer;
using WebApi.DataAccessLayer.Entities;
using WebApi.ViewModels;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("posts")]
    public class PostController : ControllerBase
    {
        private AppDbContext _dbContext;

        public PostController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost("create")]
        public Post Create(CreatePostRequest request)
        {
            var @new = new Post
            {
                Title = request.Title,
                Content = request.Content,
            };

            _dbContext.Posts.Add(@new);
            _dbContext.SaveChanges();

            return @new;
        }

        [HttpPost("get-all")]
        public Post[] GetAll()
        {
            return _dbContext.Posts.ToArray();
        }
    }
}