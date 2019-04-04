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
    public class DataAccess
    {
        public int PostInsert(Post post1)
        {
            ConnectionStringSettings bbl = ConfigurationManager.ConnectionStrings["Data Source=mssql.fhict.local;Initial Catalog=dbi365250;User ID=dbi365250"];
            SqlConnection con = new SqlConnection(bbl.ConnectionString);
            SqlCommand cmd = new SqlCommand("SP_PostInsert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@videoPath", post1.VideoPath);
            cmd.Parameters.AddWithValue("@title", post1.Title);
            cmd.Parameters.AddWithValue("@imagePath", post1.ImagePath);
            cmd.Parameters.AddWithValue("@account_id", post1.Account_id);
            cmd.Parameters.AddWithValue("@category_id", post1.Category_id);
            con.Open();
            int Result = cmd.ExecuteNonQuery();
            con.Close();
            return Result;
        }


        //public int PostInsert(Post post)
        //{
        //    ConnectionStringSettings bbl = ConfigurationManager.ConnectionStrings["Data Source=mssql.fhict.local;Initial Catalog=dbi365250;User ID=dbi365250"];
        //    SqlConnection con = new SqlConnection(bbl.ConnectionString);
        //    SqlCommand cmd = new SqlCommand("SP_PostInsert", con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@videoPath", post.VideoPath);
        //    cmd.Parameters.AddWithValue("@title", post.Title);
        //    cmd.Parameters.AddWithValue("@imagePath", post.ImagePath);
        //    cmd.Parameters.AddWithValue("@account_id", post.Account_id);
        //    cmd.Parameters.AddWithValue("@category_id", post.Category_id);
        //    con.Open();
        //    int Result = cmd.ExecuteNonQuery();
        //    con.Close();
        //    return Result;
        //}
    }
}
