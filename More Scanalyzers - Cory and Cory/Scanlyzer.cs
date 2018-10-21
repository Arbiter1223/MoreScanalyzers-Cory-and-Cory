using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_Scanalyzers___Cory_and_Cory
{
    abstract class Scanlyzer
    {
        private int cols;//number of Columns
        private int rows;//number of Rows
        private int pieces;//number of pieces of evidence
        protected int piecesFound;//number of pieces found
        protected int[][] EvidenceLocations;//location of the evidence    

        public Scanlyzer(int c, int r, int numLocs, int[][] locs)
        {
            cols = c;
            rows = r;
            pieces = numLocs;
            piecesFound = 0;
            EvidenceLocations = new int[pieces][];
            for(int i = 0; i < pieces; i++)
            {
                EvidenceLocations[i] = new int[2]
                    { locs[i][0], locs[i][1]};
            }
        }

        public abstract bool processGeuss(int r, int c);

        public abstract string boardToString();

        public abstract int getGeusses();

        public abstract string getType();

        protected bool allFound()
        {
            return pieces == piecesFound;
        }
    }
}
