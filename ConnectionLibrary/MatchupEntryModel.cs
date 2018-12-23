using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionLibrary
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Reprezntuje jedną drużynę w meczu.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Reperezntuje liczbę punktów per drużyna.
        /// </summary>
        public double Store { get; set; }
        /// <summary>
        /// Reprezentuje wynik metchu i która drużyna wygrała.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
