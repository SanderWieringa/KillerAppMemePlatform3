using KillerAppMemePlatform.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerAppMemePlatform.DAL 
{
    public class PostDAL : IPostDAL, IPostCollectionDAL
    {
        private SqlConnection conn;
        const string connectionString = "Data Source=mssql.fhict.local;Initial Catalog=dbi365250;Persist Security Info=True;User ID=dbi365250;Password=Kcw0hI3FHW";

        private SqlConnection GetConnection()
        {
            return conn = new SqlConnection(connectionString);
        }

        public List<PostStruct> GetAllPosts()
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
                        postStructList.Add(new PostStruct(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                                                      reader.GetString(3), reader.GetInt32(4), reader.GetInt32(5)));
                    }
                }
            }
            return postStructList;
        }

        public bool Update(PostStruct postStruct)
        {
            throw new NotImplementedException();
        }

        public void Add(PostStruct postStruct)
        {
            using (GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_PostInsert", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@videoPath", postStruct.VideoPath);
                cmd.Parameters.AddWithValue("@title", postStruct.Title);
                cmd.Parameters.AddWithValue("@imagePath", postStruct.ImagePath);
                cmd.Parameters.AddWithValue("@account_id", postStruct.Account_id);
                cmd.Parameters.AddWithValue("@category_id", postStruct.Category_id);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            
        }
    }
}
