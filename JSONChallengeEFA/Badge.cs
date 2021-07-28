using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallengeEFA
{
    public class Badge
    {
        public int BadgeID { get; set; }
        public List<string> ListOfDoors {get; set;}
        public bool HasSecurityClearence { get; set; }
        public string EmployeeId { get; set; }
        public DateTime CreatedOn { get; set; }

        public Badge () { }

        public Badge (int badgeId, List<string> listOfDoors, bool hasSecurityClearence, string employeeId, DateTime createdOn)
        {
            BadgeID = badgeId;
            ListOfDoors = listOfDoors;
            HasSecurityClearence = hasSecurityClearence;
            EmployeeId = employeeId;
            CreatedOn = createdOn;
        }
    }
}
