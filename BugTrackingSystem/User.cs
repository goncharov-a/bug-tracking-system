using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackingSystem
{
    public class User
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public override string ToString() { return Name; }
    }
}
