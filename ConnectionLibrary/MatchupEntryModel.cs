using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionLibrary
{
    public class MatchupEntryModel
    {
        public TeamModel TeamCompeting { get; set; }
        public double Store { get; set; }
        public MatchupModel ParentMatchup { get; set; }
    }
}
