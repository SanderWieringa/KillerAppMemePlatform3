using KillerAppMemePlatform.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace KilllerAppMemePlatform1.BLL
{
    public class BusinessLogic
    {
        public int PostInsert(Post post1)
        {
            //if (post1.Title != "")
            //{
                DataAccess access = new DataAccess();
                return access.PostInsert(post1);
            //}
            
        }
    }
}
