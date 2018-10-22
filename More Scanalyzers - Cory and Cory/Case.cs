using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace More_Scanalyzers___Cory_and_Cory
{

    class Case : MoreScanalyzersForm
    {
        private int caseNum;
        private int samples;
        private Scanlyzer scaner;

        public Case(int cNum, int r, int c, int s, char type){
            Random rand = new Random();
            caseNum = cNum;
            samples = s;

            int[][] S;
            S = new int[samples][];

            int tempR;
            int tempC;

            //creates random sample locations
            for(int i = 0; i < samples; i++)
            {
                S[i] = new int[2];

                tempR = rand.Next();
                tempC = rand.Next();

                //loops through until unique coordinates are
                //generated
                for(int j = 0; j < i; j++)
                {
                    if (tempR == S[j][0] && tempC == S[j][1])
                    {
                        tempR = rand.Next();
                        tempC = rand.Next();
                        j = 0;
                    }
                }
                S[i][0] = tempR;
                S[i][1] = tempC;
            }

            //creates new scanalyzer depending on type
            switch (type)
            {
                case '@':
                    scaner = new FingerprintAnalyzer(r, c, samples, S);
                    break;
                case 'S':
                    scaner = new HairAnalyzer(r, c, samples, S);
                    break;
                case '*':
                    scaner = new BloodAnalyzer(r, c, samples, S);
                    break;
            }

            //initializes gameboard labels
            labelGrid.Text = scaner.boardToString();
            labelCaseNumber.Text = "Case Number: " + caseNum;
            labelGridSize.Text = "Grid Size: " + r + " X " + c;
            labelSampleType.Text = "Sample Type: " + scaner.getType();
            labelNumberOfSamples.Text = "Number of Samples: " + samples;
            labelGuesses.Text = "Geusses: " + 0;
            labelLastGuess.Text = "Last Geuss: none";
            buttonSubmitGuess.Enabled = true;

            for (int i = 0; i < r; i++)
            {
                labelGridRows.Text += i + '\n';
            }
            for (int i = 0; i < c; i++)
            {
                labelGridColumns.Text += ' ' + i;
            }
        }

        public void makeGeuss(int r, int c)
        {
            //if the found all samples show congratulations box
            //and return
            if (scaner.processGeuss(r, c))
            {
                MessageBox.Show("Congratulation! You found all "
                    + samples + " " + scaner.getType() + "samples",
                    "", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            int g = scaner.getGeusses();
            labelGrid.Text = scaner.boardToString();
            labelLastGuess.Text = "Last Geuss: " + r + ", " + c;
            labelGuesses.Text = "Geusses Left: " + scaner.getGeusses()
                + " / " + 30;
            switch(scaner.getBoardChar(r, c))
            {
                case '^':
                    labelGuessResponse.Text = "Go Up...";
                    break;
                case 'v':
                    labelGuessResponse.Text = "Go Down...";
                    break;
                case '>':
                    labelGuessResponse.Text = "Go Right...";
                    break;
                case '<':
                    labelGuessResponse.Text = "Go Left...";
                    break;

            }

            if (outOfGeusses())
            {
                MessageBox.Show("You Lose! You found only "
                    + scaner.getFound() + " " + scaner.getType() + "samples "
                    + "out of " + samples,
                    "", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
                buttonSubmitGuess.Enabled = false;
            }
        }

        public string boardToSting()
        {
            return scaner.boardToString();
        }

        private bool outOfGeusses()
        {
            return scaner.getGeusses() > 29;
        }

    }
}
