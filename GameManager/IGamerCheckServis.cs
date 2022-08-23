using System;
using System.Collections.Generic;
using System.Text;

namespace GameManager
{
    public interface IGamerCheckServis
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
