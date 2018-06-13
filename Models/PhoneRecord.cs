using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorePhoneBook.Models
{
    public class PhoneRecord
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
    }
}
