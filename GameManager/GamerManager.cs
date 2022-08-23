using System;
using System.Collections.Generic;
using System.Text;

namespace GameManager
{
    class GamerManager : IGamerService
    {
        private IGamerCheckServis _customerChekService;
        public GamerManager(IGamerCheckServis gamerCheckServis)
        {
            _customerChekService = gamerCheckServis;
        }
        public void DeleteAccount(Customer customer)
        {
            Console.WriteLine("Deleted");
        }

        public void Register(Customer customer)
        {
            if (_customerChekService.CheckIfRealPerson(customer))
            {
                Console.WriteLine("Succed");
                customer.Verified = true;
            }
            else
            {
                Console.WriteLine("Can not verified.");
            }
        }

        public void Save(Customer customer)
        {
            Console.WriteLine("Saved.");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Updated");
        }
    }
}
