using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp_Test.Models;

namespace WebApp_Test.Data
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> opt): base(opt)
        {

        }
        public DbSet<BlogModel> BlogModels { get; set;}


    }
}
