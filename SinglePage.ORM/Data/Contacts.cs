using System;
using System.Collections.Generic;

namespace SinglePage.ORM.Data
{
    public partial class Contacts
    {
        public int ContactId { get; set; }
        public string ContactName { get; set; }
        public string ContactSurName { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public string ContactMessage { get; set; }
    }
}
