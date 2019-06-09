using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KillerAppMemePlatform.DAL.Interfaces;

namespace KillerAppMemePlatform.DAL
{
    public class LikeSQLContext : ILikeContext
    {
        private SqlConnection conn;
        const string connectionString = "Data Source=mssql.fhict.local;Initial Catalog=dbi365250;Persist Security Info=True;User ID=dbi365250;Password=Kcw0hI3FHW";

        private SqlConnection GetConnection()
        {
            return conn = new SqlConnection(connectionString);
        }

        public void AddLike(LikeStruct likeStruct)
        {
            throw new NotImplementedException();
        }

        public void RemoveLike(int LikeId)
        {
            throw new NotImplementedException();
        }
    }
}
