using System;
using System.Collections.Generic;
using System.Text;
using FortuneDAL.Entities;

namespace FortuneDAL.Interfaces
{
        public interface IClientManager : IDisposable
        {
            void Create(ClientProfile item);
        }

}
