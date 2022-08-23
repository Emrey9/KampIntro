using System;
using System.Collections.Generic;
using System.Text;

namespace GameManager
{
    interface IGamerService
    {
        void Register(Customer customer);
        void Save(Customer customer);
        void Update(Customer customer);
        void DeleteAccount(Customer customer);
    }
}
