using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_Scanalyzers___Cory_and_Cory
{
    //Scanlyzer
    //abstract class that other scanlyzers inherit from

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

            //dynamically allocates array of sample locations and sets
            //their values based on array passed in
            EvidenceLocations = new int[pieces][];
            for(int i = 0; i < pieces; i++)
            {
                EvidenceLocations[i] = new int[2]
                    { locs[i][0], locs[i][1]};
            }
        }

        //processes a guess
        public abstract bool processGeuss(int r, int c);

        //returns board as string
        public abstract string boardToString();

        //returns guesses made
        public abstract int getGeusses();

        //returns string of scanalyzer used
        public abstract string getType();

        //returns number of samples found
        public int getFound()
        {
            return piecesFound;
        }

        //returns specific char from board
        public abstract char getBoardChar(int r, int c);

        //returns true if all samples found
        protected bool allFound()
        {
            return pieces == piecesFound;
        }
    }
}
