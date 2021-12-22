using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeams_POCOs
{
    // Plain Old C# Object
    public class DevTeam
    {
        public DevTeam() { }

        public DevTeam(string teamName, List<Developer> developer)
        {
            teamName = teamName;
            Developer = developer;
          
        }

        // unique identifer
        public int ID { get; set; }
        public string TeamName { get; set; }
        public object Developer { get; set; }
    }
}
