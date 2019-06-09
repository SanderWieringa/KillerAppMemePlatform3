using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerAppMemePlatform1.Logic.Interfaces
{
    public class LikeModel
    {
        public int LikeId { get; set; }
        public PostModel PostObject { get; set; }
    }
}
