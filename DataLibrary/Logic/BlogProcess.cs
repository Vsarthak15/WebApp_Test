using DataLibrary.DataAccess;
using DataLibrary.Model;
using System;
using System.Collections.Generic;
using System.Text;


namespace DataLibrary.Logic
{
    public static class BlogProcess
    {

        public static int Createblog(int num, string heading, string body) 
        {
            blogModel data = new blogModel
            {
                num = num,
                heading = heading,
                body = body
            };
            string sql = "insert into dbo.BlogData (num,heading,body) values ("+data.num+",'"+data.heading+"','"+data.body+"');";
            return SqlDataAccess.SaveData<blogModel>(sql);
        }

        public static int EditBlog(int num, string heading, string body)
        {
            blogModel data = new blogModel
            {
                num = num,
                heading = heading,
                body = body
            };
            string sql = "udpdate dbo.BlogData set heading='"+data.heading+"',body='"+data.body+"' where num="+data.num+";";
            return SqlDataAccess.EditData<blogModel>(sql);
        }

        public static List<blogModel> LoadBlogs()
        {
            string sql = "select * from dbo.BlogData;";
            return SqlDataAccess.LoadData<blogModel>(sql);
        }

        public static blogModel LoadBlog(int num)
        {
            string sql = "select * from dbo.BlogData where num=" + num + ";";
            return SqlDataAccess.Loadblog<blogModel>(sql);
        }

        public static int DelBlog(int num)
        {
            string sql = @"delete from dbo.BlogData where num=" + num + ";";
            return SqlDataAccess.DeleteData(sql);
        }

    }
}
