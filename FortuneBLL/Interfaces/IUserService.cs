using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using FortuneBLL.DTO;
using FortuneBLL.Infrastructure;

namespace FortuneBLL.Interfaces
{
   public interface IUserService : IDisposable
    {
        Task<OperationDetails> Create(UserDTO userDto);
        Task<ClaimsIdentity> Authenticate(UserDTO userDto);
        Task SetInitialData(UserDTO adminDto, List<string> roles);
    }
}
