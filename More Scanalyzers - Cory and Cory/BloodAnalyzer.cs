using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_Scanalyzers___Cory_and_Cory
{
    class BloodAnalyzer : HairAnalyzer
    {
        public BloodAnalyzer(int r, int c, int numLocs, int[][] locs)
            : base(r, c, numLocs, locs, '*')
        {
        }
    }
}
