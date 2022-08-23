using System;
using System.Collections.Generic;
using System.Text;

namespace GameManager
{
    class EDevletServisAdapter : IGamerCheckServis
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
