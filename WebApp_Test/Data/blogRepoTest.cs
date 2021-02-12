using DataLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp_Test.Models;
using static DataLibrary.Logic.BlogProcess;

namespace WebApp_Test.Data
{
    public class blogRepoTest : blogRepo
    {
        public IEnumerable<BlogModel> GetAllBlogs()
        {
            List<blogModel> data = LoadBlogs();
            List<BlogModel> blogs = new List<BlogModel>();
            foreach (var row in data)
            {
                blogs.Add(new BlogModel
                {
                    ID = row.num,
                    BlogHeader = row.heading,
                    BlogBody = row.body
                });
            }
            return blogs;
        }

        public BlogModel GetBlogById(int id)
        {
            blogModel data = LoadBlog(id);
            BlogModel blog = new BlogModel
            {
                ID = data.num,
                BlogHeader = data.heading,
                BlogBody = data.body
            };
            return blog;
        }
        public int CreateBlog(int num, string heading, string body)
        {
            int data = Createblog(num, heading, body);
            return data;
        }
        public int EditBlog(int num, string heading, string body)
        {
            int data = EditBlog(num, heading, body);
            return data;
        }

        public int DeleteBlogById(int id)
        {
            int data = DelBlog(id);
            return data;
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
