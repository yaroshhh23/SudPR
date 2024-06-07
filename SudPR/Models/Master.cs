﻿using SudPR.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudPR.Models
{
    public class Master: IAccount
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public Role Role => Role.Master;
    }
}
