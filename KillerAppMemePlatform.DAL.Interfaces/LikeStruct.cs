﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerAppMemePlatform.DAL.Interfaces
{
    public struct LikeStruct
    {
        public int LikeId { get; set; } 
        public PostStruct PostObject { get; set; }
    }
}
