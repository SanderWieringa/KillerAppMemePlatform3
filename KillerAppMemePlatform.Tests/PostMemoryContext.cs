using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KillerAppMemePlatform.DAL.Interfaces;

namespace KillerAppMemePlatform.DAL
{
    public class PostMemoryContext : IPostContext
    {
        private SqlConnection conn;
        const string connectionString = "Data Source=mssql.fhict.local;Initial Catalog=dbi365250;Persist Security Info=True;User ID=dbi365250;Password=Kcw0hI3FHW";


        private SqlConnection GetConnection()
        {
            return conn = new SqlConnection(connectionString);
        }

        public void Add(PostStruct postStruct)
        {
            using (GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_PostInsert", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@videoPath", postStruct.FilePath);
                cmd.Parameters.AddWithValue("@title", postStruct.Title);
                cmd.Parameters.AddWithValue("@account_id", postStruct.AccountId);
                cmd.Parameters.AddWithValue("@category_id", postStruct.CategoryId);
                cmd.Parameters.AddWithValue("@status_id", postStruct.StatusId);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public List<PostStruct> GetAll()
        {
            List<PostStruct> postStructList = new List<PostStruct>();
            using (GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_GetAllPosts", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        postStructList.Add(new PostStruct(reader.GetInt32(0), reader.GetString(1) as string, reader.GetString(2) as string,
                                                          reader.GetInt32(3), (reader.GetInt32(4) as int?) ?? 0, reader.GetInt32(5)));
                    }
                }
            }
            return postStructList;
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
