using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_Scanalyzers___Cory_and_Cory
{
    class FingerprintAnalyzer : Scanlyzer
    {
        private Board game;

        public FingerprintAnalyzer(int r, int c, int numLocs, 
            int[][] locs) : base(r, c, numLocs, locs)
        {
            game = new Board(r, c, '@');
        }

        public override bool processGeuss(int r, int c)
        {
            if (game.changeBoard(r, c, EvidenceLocations[piecesFound][0],
                EvidenceLocations[piecesFound][1]))
                    incrementPiecesFound();
            if (allFound())
                return true;
            else
                return false;
        }

        public override string boardToString()
        {
            return game.GameBoardToString();
        }
    }
}
