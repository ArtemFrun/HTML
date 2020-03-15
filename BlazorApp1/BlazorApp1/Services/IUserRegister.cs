using BlazorApp1.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Services
{
    interface IUserRegister
    {
        public Task Create(User user);
    }
}
