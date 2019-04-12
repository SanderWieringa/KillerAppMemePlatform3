using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerAppMemePlatform1.Logic.Interfaces
{
    public interface IPost
    {
        int Post_id { get; set; }
        string FilePath { get; set; }
        string Title { get; set; }
        int Account_id { get; set; }
        int Category_id { get; set; }

        void Update();
    }
}
