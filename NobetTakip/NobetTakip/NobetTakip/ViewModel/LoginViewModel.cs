﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NobetTakip.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        public string MailAddress { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
        public string ReturnPath { get; set; }
    }
}
