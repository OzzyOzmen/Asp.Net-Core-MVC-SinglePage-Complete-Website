using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglePage.DTO
{
    public class ContactsDTO
    {
        public int ContactId { get; set; }
        public string ContactName { get; set; }
        public string ContactSurName { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public string ContactMessage { get; set; }
    }
}
