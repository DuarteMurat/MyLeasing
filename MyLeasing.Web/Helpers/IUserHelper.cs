﻿using Microsoft.AspNetCore.Identity;
using MyLeasing.Web.Data.Entities;
using System.Threading.Tasks;

namespace MyLeasing.Web.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUSerByEmailAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);
    }
}
