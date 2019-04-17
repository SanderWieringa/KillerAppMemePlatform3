using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerAppMemePlatform1.Logic.Interfaces
{
    public interface IPost
    {
        int PostId { get; set; }
        string FilePath { get; set; }
        string Title { get; set; }
        int AccountId { get; set; }
        int CategoryId { get; set; }

        void Update();
    }
}
