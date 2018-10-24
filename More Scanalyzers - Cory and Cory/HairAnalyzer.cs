using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_Scanalyzers___Cory_and_Cory
{
    //HairAnalyzer
    //scanlyzer that looks for hair sample or S
    class HairAnalyzer : Scanlyzer
    {
        private Board game;

        public HairAnalyzer(int r, int c, int numLocs,
            int[][] locs) : base(r, c, numLocs, locs)
        {
            game = new Board(r, c, 'S');
        }

        //processes geuss made by user
        public override bool processGeuss(int r, int c)
        {
			if (game.changeBoard(r, c, EvidenceLocations[piecesFound][0],
				EvidenceLocations[piecesFound][1]))
				piecesFound++;
			if (allFound())
                return true;
            else
                return false;
        }

        //returns number of geusses made
		public override int getGeusses()
		{
			return game.getGeusses();
		}

        //returns string indicating type
        public override string getType()
		{
			return "hair ";
		}

        //returns specific char from board
        public override char getBoardChar(int r, int c)
		{
			return game.getChar(r, c);
		}

        //returns board as a string
        public override string boardToString()
        {
            return game.GameBoardToString();
        }
    }
}
