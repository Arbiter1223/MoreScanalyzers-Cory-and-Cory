namespace More_Scanalyzers___Cory_and_Cory
{
	partial class MoreScanalyzersForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoreScanalyzersForm));
            this.buttonOpenCaseFile = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelGrid = new System.Windows.Forms.Label();
            this.labelLastGuess = new System.Windows.Forms.Label();
            this.labelInstructionsTitle = new System.Windows.Forms.Label();
            this.labelGridRows = new System.Windows.Forms.Label();
            this.labelGridColumns = new System.Windows.Forms.Label();
            this.labelGuessResponse = new System.Windows.Forms.Label();
            this.labelGridSize = new System.Windows.Forms.Label();
            this.labelInstructions = new System.Windows.Forms.Label();
            this.textBoxGuessColumn = new System.Windows.Forms.TextBox();
            this.textBoxGuessRow = new System.Windows.Forms.TextBox();
            this.labelGuessColumn = new System.Windows.Forms.Label();
            this.labelGuessRow = new System.Windows.Forms.Label();
            this.buttonSubmitGuess = new System.Windows.Forms.Button();
            this.labelGuesses = new System.Windows.Forms.Label();
            this.labelSampleType = new System.Windows.Forms.Label();
            this.labelNumberOfSamples = new System.Windows.Forms.Label();
            this.labelCaseNumber = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxScanner1 = new System.Windows.Forms.PictureBox();
            this.buttonCreateCaseFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScanner1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenCaseFile
            // 
            this.buttonOpenCaseFile.Location = new System.Drawing.Point(38, 187);
            this.buttonOpenCaseFile.Name = "buttonOpenCaseFile";
            this.buttonOpenCaseFile.Size = new System.Drawing.Size(100, 50);
            this.buttonOpenCaseFile.TabIndex = 4;
            this.buttonOpenCaseFile.Text = "Open Case File";
            this.buttonOpenCaseFile.UseVisualStyleBackColor = true;
            this.buttonOpenCaseFile.Click += new System.EventHandler(this.buttonOpenCaseFile_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(144, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(297, 37);
            this.labelTitle.TabIndex = 14;
            this.labelTitle.Text = "More Scanalyzers!";
            // 
            // labelGrid
            // 
            this.labelGrid.AutoSize = true;
            this.labelGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrid.Location = new System.Drawing.Point(197, 196);
            this.labelGrid.Name = "labelGrid";
            this.labelGrid.Size = new System.Drawing.Size(135, 200);
            this.labelGrid.TabIndex = 48;
            this.labelGrid.Text = resources.GetString("labelGrid.Text");
            // 
            // labelLastGuess
            // 
            this.labelLastGuess.AutoSize = true;
            this.labelLastGuess.Location = new System.Drawing.Point(412, 235);
            this.labelLastGuess.Name = "labelLastGuess";
            this.labelLastGuess.Size = new System.Drawing.Size(82, 13);
            this.labelLastGuess.TabIndex = 47;
            this.labelLastGuess.Text = "Last guess: 0, 0";
            // 
            // labelInstructionsTitle
            // 
            this.labelInstructionsTitle.AutoSize = true;
            this.labelInstructionsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstructionsTitle.Location = new System.Drawing.Point(46, 103);
            this.labelInstructionsTitle.Name = "labelInstructionsTitle";
            this.labelInstructionsTitle.Size = new System.Drawing.Size(92, 20);
            this.labelInstructionsTitle.TabIndex = 46;
            this.labelInstructionsTitle.Text = "Instructions";
            // 
            // labelGridRows
            // 
            this.labelGridRows.AutoSize = true;
            this.labelGridRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGridRows.Location = new System.Drawing.Point(179, 196);
            this.labelGridRows.Name = "labelGridRows";
            this.labelGridRows.Size = new System.Drawing.Size(18, 200);
            this.labelGridRows.TabIndex = 44;
            this.labelGridRows.Text = "0\r\n1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n7\r\n8\r\n9";
            // 
            // labelGridColumns
            // 
            this.labelGridColumns.AutoSize = true;
            this.labelGridColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGridColumns.Location = new System.Drawing.Point(188, 176);
            this.labelGridColumns.Name = "labelGridColumns";
            this.labelGridColumns.Size = new System.Drawing.Size(139, 20);
            this.labelGridColumns.TabIndex = 43;
            this.labelGridColumns.Text = " 0 1 2 3 4 5 6 7 8 9";
            // 
            // labelGuessResponse
            // 
            this.labelGuessResponse.AutoSize = true;
            this.labelGuessResponse.Location = new System.Drawing.Point(412, 257);
            this.labelGuessResponse.Name = "labelGuessResponse";
            this.labelGuessResponse.Size = new System.Drawing.Size(138, 13);
            this.labelGuessResponse.TabIndex = 42;
            this.labelGuessResponse.Text = "Guess Response goes here";
            // 
            // labelGridSize
            // 
            this.labelGridSize.AutoSize = true;
            this.labelGridSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGridSize.Location = new System.Drawing.Point(200, 102);
            this.labelGridSize.Name = "labelGridSize";
            this.labelGridSize.Size = new System.Drawing.Size(103, 15);
            this.labelGridSize.TabIndex = 37;
            this.labelGridSize.Text = "Grid Size: 00 x 00";
            // 
            // labelInstructions
            // 
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.Location = new System.Drawing.Point(12, 127);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(166, 52);
            this.labelInstructions.TabIndex = 36;
            this.labelInstructions.Text = "Enter the coordinates of a space\r\nat the bottom of the form to reveal\r\nthat space" +
    ". Must be within the\r\nbounds of the grid.";
            // 
            // textBoxGuessColumn
            // 
            this.textBoxGuessColumn.Location = new System.Drawing.Point(285, 404);
            this.textBoxGuessColumn.Name = "textBoxGuessColumn";
            this.textBoxGuessColumn.Size = new System.Drawing.Size(50, 20);
            this.textBoxGuessColumn.TabIndex = 35;
            // 
            // textBoxGuessRow
            // 
            this.textBoxGuessRow.Location = new System.Drawing.Point(178, 404);
            this.textBoxGuessRow.Name = "textBoxGuessRow";
            this.textBoxGuessRow.Size = new System.Drawing.Size(50, 20);
            this.textBoxGuessRow.TabIndex = 34;
            // 
            // labelGuessColumn
            // 
            this.labelGuessColumn.AutoSize = true;
            this.labelGuessColumn.Location = new System.Drawing.Point(234, 407);
            this.labelGuessColumn.Name = "labelGuessColumn";
            this.labelGuessColumn.Size = new System.Drawing.Size(45, 13);
            this.labelGuessColumn.TabIndex = 33;
            this.labelGuessColumn.Text = "Column:";
            // 
            // labelGuessRow
            // 
            this.labelGuessRow.AutoSize = true;
            this.labelGuessRow.Location = new System.Drawing.Point(140, 407);
            this.labelGuessRow.Name = "labelGuessRow";
            this.labelGuessRow.Size = new System.Drawing.Size(32, 13);
            this.labelGuessRow.TabIndex = 32;
            this.labelGuessRow.Text = "Row:";
            // 
            // buttonSubmitGuess
            // 
            this.buttonSubmitGuess.Location = new System.Drawing.Point(341, 402);
            this.buttonSubmitGuess.Name = "buttonSubmitGuess";
            this.buttonSubmitGuess.Size = new System.Drawing.Size(94, 23);
            this.buttonSubmitGuess.TabIndex = 31;
            this.buttonSubmitGuess.Text = "Submit Guess";
            this.buttonSubmitGuess.UseVisualStyleBackColor = true;
            // 
            // labelGuesses
            // 
            this.labelGuesses.AutoSize = true;
            this.labelGuesses.Location = new System.Drawing.Point(412, 214);
            this.labelGuesses.Name = "labelGuesses";
            this.labelGuesses.Size = new System.Drawing.Size(60, 13);
            this.labelGuesses.TabIndex = 30;
            this.labelGuesses.Text = "Guesses: 0";
            // 
            // labelSampleType
            // 
            this.labelSampleType.AutoSize = true;
            this.labelSampleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSampleType.Location = new System.Drawing.Point(200, 122);
            this.labelSampleType.Name = "labelSampleType";
            this.labelSampleType.Size = new System.Drawing.Size(85, 15);
            this.labelSampleType.TabIndex = 50;
            this.labelSampleType.Text = "Sample Type: ";
            // 
            // labelNumberOfSamples
            // 
            this.labelNumberOfSamples.AutoSize = true;
            this.labelNumberOfSamples.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfSamples.Location = new System.Drawing.Point(200, 142);
            this.labelNumberOfSamples.Name = "labelNumberOfSamples";
            this.labelNumberOfSamples.Size = new System.Drawing.Size(123, 15);
            this.labelNumberOfSamples.TabIndex = 51;
            this.labelNumberOfSamples.Text = "Number of Samples: ";
            // 
            // labelCaseNumber
            // 
            this.labelCaseNumber.AutoSize = true;
            this.labelCaseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCaseNumber.Location = new System.Drawing.Point(192, 62);
            this.labelCaseNumber.Name = "labelCaseNumber";
            this.labelCaseNumber.Size = new System.Drawing.Size(201, 26);
            this.labelCaseNumber.TabIndex = 52;
            this.labelCaseNumber.Text = "Case Number 0000";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::More_Scanalyzers___Cory_and_Cory.Properties.Resources.SubnauticaScanner;
            this.pictureBox1.Location = new System.Drawing.Point(447, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 54);
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxScanner1
            // 
            this.pictureBoxScanner1.Image = global::More_Scanalyzers___Cory_and_Cory.Properties.Resources.SubnauticaScanner;
            this.pictureBoxScanner1.Location = new System.Drawing.Point(84, 12);
            this.pictureBoxScanner1.Name = "pictureBoxScanner1";
            this.pictureBoxScanner1.Size = new System.Drawing.Size(54, 54);
            this.pictureBoxScanner1.TabIndex = 0;
            this.pictureBoxScanner1.TabStop = false;
            // 
            // buttonCreateCaseFile
            // 
            this.buttonCreateCaseFile.Location = new System.Drawing.Point(38, 243);
            this.buttonCreateCaseFile.Name = "buttonCreateCaseFile";
            this.buttonCreateCaseFile.Size = new System.Drawing.Size(100, 50);
            this.buttonCreateCaseFile.TabIndex = 53;
            this.buttonCreateCaseFile.Text = "Create Case File";
            this.buttonCreateCaseFile.UseVisualStyleBackColor = true;
            this.buttonCreateCaseFile.Click += new System.EventHandler(this.buttonCreateCaseFile_Click);
            // 
            // MoreScanalyzersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.buttonCreateCaseFile);
            this.Controls.Add(this.labelCaseNumber);
            this.Controls.Add(this.labelNumberOfSamples);
            this.Controls.Add(this.labelSampleType);
            this.Controls.Add(this.buttonOpenCaseFile);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelGrid);
            this.Controls.Add(this.labelLastGuess);
            this.Controls.Add(this.labelInstructionsTitle);
            this.Controls.Add(this.labelGridRows);
            this.Controls.Add(this.labelGridColumns);
            this.Controls.Add(this.labelGuessResponse);
            this.Controls.Add(this.labelGridSize);
            this.Controls.Add(this.labelInstructions);
            this.Controls.Add(this.textBoxGuessColumn);
            this.Controls.Add(this.textBoxGuessRow);
            this.Controls.Add(this.labelGuessColumn);
            this.Controls.Add(this.labelGuessRow);
            this.Controls.Add(this.buttonSubmitGuess);
            this.Controls.Add(this.labelGuesses);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBoxScanner1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MoreScanalyzersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "More Scanalyzers!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScanner1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button buttonOpenCaseFile;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.Label labelInstructionsTitle;
		private System.Windows.Forms.Label labelInstructions;
		private System.Windows.Forms.TextBox textBoxGuessColumn;
		private System.Windows.Forms.TextBox textBoxGuessRow;
		private System.Windows.Forms.Label labelGuessColumn;
		private System.Windows.Forms.Label labelGuessRow;
		private System.Windows.Forms.PictureBox pictureBoxScanner1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button buttonCreateCaseFile;
        protected System.Windows.Forms.Label labelGridColumns;
        protected System.Windows.Forms.Label labelGrid;
        protected System.Windows.Forms.Label labelLastGuess;
        protected System.Windows.Forms.Label labelGridRows;
        protected System.Windows.Forms.Label labelGuessResponse;
        protected System.Windows.Forms.Label labelGridSize;
        protected System.Windows.Forms.Label labelGuesses;
        protected System.Windows.Forms.Label labelSampleType;
        public System.Windows.Forms.Label labelNumberOfSamples;
        protected System.Windows.Forms.Label labelCaseNumber;
        protected System.Windows.Forms.Button buttonSubmitGuess;
    }
}

