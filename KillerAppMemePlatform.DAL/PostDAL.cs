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
    public class PostDAL
    {
        public int PostInsert(PostStruct postStruct)
        {
            ConnectionStringSettings bbl = ConfigurationManager.ConnectionStrings["Data Source=mssql.fhict.local;Initial Catalog=dbi365250;User ID=dbi365250"];
            SqlConnection con = new SqlConnection(bbl.ConnectionString);
            SqlCommand cmd = new SqlCommand("SP_PostInsert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@videoPath", postStruct.VideoPath);
            cmd.Parameters.AddWithValue("@title", postStruct.Title);
            cmd.Parameters.AddWithValue("@imagePath", postStruct.ImagePath);
            cmd.Parameters.AddWithValue("@account_id", postStruct.Account_id);
            cmd.Parameters.AddWithValue("@category_id", postStruct.Category_id);
            con.Open();
            int Result = cmd.ExecuteNonQuery();
            con.Close();
            return Result;
        }
    }
}
