﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class User : BaseEntity
    {
    
        public string Name { get; set; }

        public string Email { get; set; }

        public int Phnnum { get; set; }
    }
}