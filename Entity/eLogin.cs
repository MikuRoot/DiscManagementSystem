﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class eLogin
    {
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
