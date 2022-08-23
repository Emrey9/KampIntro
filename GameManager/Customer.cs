using System;
using System.Collections.Generic;
using System.Text;

namespace GameManager
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string TcNo { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Verified { get; set; }
    }
}
