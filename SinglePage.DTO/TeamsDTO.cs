using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglePage.DTO
{
    public class TeamsDTO
    {
        public int TeamId { get; set; }
        public string TeamPhoto { get; set; }
        public string TeamTitle { get; set; }
        public string TeamMemberName { get; set; }
        public string TeamMemberSurName { get; set; }
        public string AboutTeamMember { get; set; }
        public string TeamFacebookLink { get; set; }
        public string TeamTwitterLink { get; set; }
        public string TeamLinkedInLink { get; set; }
    }
}
