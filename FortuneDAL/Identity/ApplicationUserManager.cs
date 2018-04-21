using System;
using System.Collections.Generic;
using System.Text;
using FortuneDAL.Entities;
using Microsoft.AspNet.Identity;

namespace FortuneDAL.Identity
{
    public class ApplicationUserManager:UserManager<ApplicationUser>
    {

    public ApplicationUserManager(IUserStore<ApplicationUser> store)
        : base(store)
    {
    }
    }
}
