using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp_Test.Data;
using WebApp_Test.Models;
using static DataLibrary.Logic.BlogProcess;

namespace WebApp_Test.Controllers
{
    [Route("api/blog")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly blogRepo Repo_test;
        public BlogController(blogRepo repo)
        {
            Repo_test = repo;
        }

        [HttpGet]
        public ActionResult <IEnumerable<BlogModel>> GetAllBlogs()
        {
            var blogItems = Repo_test.GetAllBlogs();
            return Ok(blogItems);
        }


        [HttpGet("{id}")]
        public ActionResult<BlogModel> GetBlogByID(int id) 
        {
            var blogItems = Repo_test.GetBlogById(id);
            return Ok(blogItems);
        }


        [HttpDelete("{id}")]
        public ActionResult DeleteBlogByID(int id)
        {
            var blogItems = Repo_test.DeleteBlogById(id);
            return Ok(blogItems);
        }


        [HttpPost("Create")]
        public ActionResult CreateBlog(BlogModel blog)
        {
            if (ModelState.IsValid) 
            {
                int create = Repo_test.CreateBlog(blog.ID,blog.BlogHeader,blog.BlogBody);
                return Ok(create);
            }
            return Ok(0);
            
        }

        [HttpPost("Edit")]
        public ActionResult EditBlog(BlogModel blog)
        {
            if (ModelState.IsValid)
            {
                int create = Repo_test.EditBlog(blog.ID, blog.BlogHeader, blog.BlogBody);
                return Ok(create);
            }
            return Ok(0);

        }
    }
}
