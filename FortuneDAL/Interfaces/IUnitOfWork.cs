using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FortuneDAL.Identity;

namespace FortuneDAL.Interfaces
{
   public interface IUnitOfWork:IDisposable
    {
        ApplicationUserManager UserManager { get; }
        IClientManager ClientManager { get; }
        ApplicationRoleManager RoleManager { get; }
        Task SaveAsync();
    }
}
