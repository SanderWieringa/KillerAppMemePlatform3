using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilllerAppMemePlatform1.BLL
{
    public class Like
    {
        public int like_id { get; set; }
        public int account_id { get; set; }
        public int? post_id { get; set; }
        public int? comment_id { get; set; }

    }
}
