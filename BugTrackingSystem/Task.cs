using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackingSystem
{
    public class Task
    {
        public Project Project { get; set; }
        public User User { get; set; }
        public string Type { get; set; }
        public string Priority { get; set; }
        public string Description { get; set; }
        public int Number { get; set; }
    }
}
