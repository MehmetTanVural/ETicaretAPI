﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.DTOs
{
    public class Token
    {
        public string Access { get; set; }
        public DateTime Expiration { get; set; }
    }
}
