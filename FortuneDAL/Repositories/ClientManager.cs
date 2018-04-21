using System;
using System.Collections.Generic;
using System.Text;
using FortuneDAL.EF;
using FortuneDAL.Interfaces;
using FortuneDAL.Entities;

namespace FortuneDAL.Repositories
{
    public class ClientManager : IClientManager
    {
        public ApplicationContext Database { get; set; }

        public ClientManager(ApplicationContext db)
        {
            Database = db;
        }

        public void Create(ClientProfile item)
        {
            Database.ClientProfiles.Add(item);
            Database.SaveChanges();
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
