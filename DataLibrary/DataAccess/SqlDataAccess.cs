using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using DataLibrary.Model;

namespace DataLibrary.DataAccess
{
    public static class SqlDataAccess
    {
        
        public static string GetConnectionString() 
        {
            return "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MVCTestDB;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }
        public static List<T> LoadData<T> (string sql)
        {
            using (IDbConnection cnm = new SqlConnection(GetConnectionString())) 
            {
                return cnm.Query<T>(sql).ToList();
            }
        }
        public static blogModel Loadblog<blogModel>(string sql)
        {
                using (IDbConnection cnm = new SqlConnection(GetConnectionString()))
                {
                    return cnm.Query<blogModel>(sql).ToList().ElementAt(0);
                }
        }

        public static int SaveData<T>(string sql)
        {
                using (IDbConnection cnm = new SqlConnection(GetConnectionString()))
                {
                    return cnm.Execute(sql);
                }
        }
        public static int EditData<T>(string sql)
        {
            using (IDbConnection cnm = new SqlConnection(GetConnectionString()))
            {
                return cnm.Execute(sql);
            }
        }
        public static int DeleteData(string sql)
        {
                using (IDbConnection cnm = new SqlConnection(GetConnectionString()))
                {
                    return cnm.Execute(sql);
                }
        }

    }
}
