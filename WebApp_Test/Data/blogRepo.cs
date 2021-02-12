using DataLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp_Test.Models;

namespace WebApp_Test.Data
{
    public interface blogRepo
    {
        bool SaveChanges();
        IEnumerable<BlogModel> GetAllBlogs();
        BlogModel GetBlogById(int id);
        int CreateBlog(int num, string heading, string body);
        int EditBlog(int num, string heading, string body);
        int DeleteBlogById(int id);

    }
}
