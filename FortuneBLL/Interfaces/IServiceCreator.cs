using System;
using System.Collections.Generic;
using System.Text;

namespace FortuneBLL.Interfaces
{
   public  interface IServiceCreator
   {
       IUserService CreateUserService(string connection);// ninject MAy?
   }
}
