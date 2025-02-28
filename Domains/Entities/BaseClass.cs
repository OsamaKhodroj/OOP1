using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Domains
{
    public class BaseClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string Address { get; set; }
        public List<string> PhoneNumber { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
