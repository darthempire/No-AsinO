using FortuneBLL.Interfaces;
using FortuneDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace FortuneBLL.Services
{
    public  class ServiceCreator :IServiceCreator
    {
        public IUserService CreateUserService(string connection)
        {
            return new UserService(new IdentityUnitOfWork(connection));
        }
    }
}
