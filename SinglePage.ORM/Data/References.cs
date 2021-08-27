using System;
using System.Collections.Generic;

namespace SinglePage.ORM.Data
{
    public partial class References
    {
        public int ReferenceId { get; set; }
        public string ReferencePhoto { get; set; }
        public string ReferenceTitle { get; set; }
        public string ReferenceLink { get; set; }
        public string ReferenceCategory { get; set; }
    }
}
