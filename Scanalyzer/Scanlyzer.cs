namespace Scanalyzer
{
    abstract class Scanlyzer
    {
        private int cols;	// Number of Columns
        private int rows;	// Number of Rows
        private int pieces;	// Number of pieces of evidence
        protected int piecesFound;	// Number of pieces found
        protected int[][] EvidenceLocations;	// Location of the evidence

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

        public abstract bool processGuess(int r, int c);

        public abstract string boardToString();

        public abstract int getGuesses();

        public abstract string getType();

        public int getFound()
        {
            return piecesFound;
        }

        public abstract char getBoardChar(int r, int c);


        protected bool allFound()
        {
            return pieces == piecesFound;
        }
    }
}
