using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class User
    {
        public string NickName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string passwordConfirm { set; get; }
    }
}
