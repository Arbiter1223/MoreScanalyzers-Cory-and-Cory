namespace FindSampleGame___Cory_Michener
{
	partial class FindSampleGameForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindSampleGameForm));
			this.labelGuesses = new System.Windows.Forms.Label();
			this.buttonSubmitGuess = new System.Windows.Forms.Button();
			this.labelGuessRow = new System.Windows.Forms.Label();
			this.labelGuessColumn = new System.Windows.Forms.Label();
			this.textBoxGuessRow = new System.Windows.Forms.TextBox();
			this.textBoxGuessColumn = new System.Windows.Forms.TextBox();
			this.labelInstructions = new System.Windows.Forms.Label();
			this.labelGridSize = new System.Windows.Forms.Label();
			this.labelGridSizeRows = new System.Windows.Forms.Label();
			this.labalGridSizeColumns = new System.Windows.Forms.Label();
			this.textBoxGridSizeColumns = new System.Windows.Forms.TextBox();
			this.textBoxGridSizeRows = new System.Windows.Forms.TextBox();
			this.labelGuessResponse = new System.Windows.Forms.Label();
			this.labelTitle = new System.Windows.Forms.Label();
			this.labelGridColumns = new System.Windows.Forms.Label();
			this.labelGridRows = new System.Windows.Forms.Label();
			this.buttonStartGame = new System.Windows.Forms.Button();
			this.labelInstructionsTitle = new System.Windows.Forms.Label();
			this.labelLastGuess = new System.Windows.Forms.Label();
			this.labelGrid = new System.Windows.Forms.Label();
			this.pictureBoxMagnifyingGlass = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxMagnifyingGlass)).BeginInit();
			this.SuspendLayout();
			// 
			// labelGuesses
			// 
			this.labelGuesses.AutoSize = true;
			this.labelGuesses.Location = new System.Drawing.Point(411, 202);
			this.labelGuesses.Name = "labelGuesses";
			this.labelGuesses.Size = new System.Drawing.Size(54, 13);
			this.labelGuesses.TabIndex = 0;
			this.labelGuesses.Text = "Guesses: ";
			// 
			// buttonSubmitGuess
			// 
			this.buttonSubmitGuess.Location = new System.Drawing.Point(346, 390);
			this.buttonSubmitGuess.Name = "buttonSubmitGuess";
			this.buttonSubmitGuess.Size = new System.Drawing.Size(94, 23);
			this.buttonSubmitGuess.TabIndex = 1;
			this.buttonSubmitGuess.Text = "Submit Guess";
			this.buttonSubmitGuess.UseVisualStyleBackColor = true;
			this.buttonSubmitGuess.Click += new System.EventHandler(this.buttonSubmitGuess_Click);
			// 
			// labelGuessRow
			// 
			this.labelGuessRow.AutoSize = true;
			this.labelGuessRow.Location = new System.Drawing.Point(145, 395);
			this.labelGuessRow.Name = "labelGuessRow";
			this.labelGuessRow.Size = new System.Drawing.Size(32, 13);
			this.labelGuessRow.TabIndex = 2;
			this.labelGuessRow.Text = "Row:";
			// 
			// labelGuessColumn
			// 
			this.labelGuessColumn.AutoSize = true;
			this.labelGuessColumn.Location = new System.Drawing.Point(239, 395);
			this.labelGuessColumn.Name = "labelGuessColumn";
			this.labelGuessColumn.Size = new System.Drawing.Size(45, 13);
			this.labelGuessColumn.TabIndex = 3;
			this.labelGuessColumn.Text = "Column:";
			// 
			// textBoxGuessRow
			// 
			this.textBoxGuessRow.Location = new System.Drawing.Point(183, 392);
			this.textBoxGuessRow.Name = "textBoxGuessRow";
			this.textBoxGuessRow.Size = new System.Drawing.Size(50, 20);
			this.textBoxGuessRow.TabIndex = 4;
			// 
			// textBoxGuessColumn
			// 
			this.textBoxGuessColumn.Location = new System.Drawing.Point(290, 392);
			this.textBoxGuessColumn.Name = "textBoxGuessColumn";
			this.textBoxGuessColumn.Size = new System.Drawing.Size(50, 20);
			this.textBoxGuessColumn.TabIndex = 5;
			// 
			// labelInstructions
			// 
			this.labelInstructions.AutoSize = true;
			this.labelInstructions.Location = new System.Drawing.Point(25, 119);
			this.labelInstructions.Name = "labelInstructions";
			this.labelInstructions.Size = new System.Drawing.Size(100, 13);
			this.labelInstructions.TabIndex = 6;
			this.labelInstructions.Text = "Instructions go here";
			// 
			// labelGridSize
			// 
			this.labelGridSize.AutoSize = true;
			this.labelGridSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelGridSize.Location = new System.Drawing.Point(255, 65);
			this.labelGridSize.Name = "labelGridSize";
			this.labelGridSize.Size = new System.Drawing.Size(74, 20);
			this.labelGridSize.TabIndex = 7;
			this.labelGridSize.Text = "Grid Size";
			// 
			// labelGridSizeRows
			// 
			this.labelGridSizeRows.AutoSize = true;
			this.labelGridSizeRows.Location = new System.Drawing.Point(190, 91);
			this.labelGridSizeRows.Name = "labelGridSizeRows";
			this.labelGridSizeRows.Size = new System.Drawing.Size(37, 13);
			this.labelGridSizeRows.TabIndex = 8;
			this.labelGridSizeRows.Text = "Rows:";
			// 
			// labalGridSizeColumns
			// 
			this.labalGridSizeColumns.AutoSize = true;
			this.labalGridSizeColumns.Location = new System.Drawing.Point(289, 90);
			this.labalGridSizeColumns.Name = "labalGridSizeColumns";
			this.labalGridSizeColumns.Size = new System.Drawing.Size(50, 13);
			this.labalGridSizeColumns.TabIndex = 9;
			this.labalGridSizeColumns.Text = "Columns:";
			// 
			// textBoxGridSizeColumns
			// 
			this.textBoxGridSizeColumns.Location = new System.Drawing.Point(345, 87);
			this.textBoxGridSizeColumns.Name = "textBoxGridSizeColumns";
			this.textBoxGridSizeColumns.Size = new System.Drawing.Size(50, 20);
			this.textBoxGridSizeColumns.TabIndex = 11;
			// 
			// textBoxGridSizeRows
			// 
			this.textBoxGridSizeRows.Location = new System.Drawing.Point(233, 88);
			this.textBoxGridSizeRows.Name = "textBoxGridSizeRows";
			this.textBoxGridSizeRows.Size = new System.Drawing.Size(50, 20);
			this.textBoxGridSizeRows.TabIndex = 10;
			// 
			// labelGuessResponse
			// 
			this.labelGuessResponse.AutoSize = true;
			this.labelGuessResponse.Location = new System.Drawing.Point(411, 245);
			this.labelGuessResponse.Name = "labelGuessResponse";
			this.labelGuessResponse.Size = new System.Drawing.Size(138, 13);
			this.labelGuessResponse.TabIndex = 12;
			this.labelGuessResponse.Text = "Guess Response goes here";
			// 
			// labelTitle
			// 
			this.labelTitle.AutoSize = true;
			this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitle.Location = new System.Drawing.Point(146, 16);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(292, 37);
			this.labelTitle.TabIndex = 13;
			this.labelTitle.Text = "Find the Samples!";
			// 
			// labelGridColumns
			// 
			this.labelGridColumns.AutoSize = true;
			this.labelGridColumns.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelGridColumns.Location = new System.Drawing.Point(193, 158);
			this.labelGridColumns.Name = "labelGridColumns";
			this.labelGridColumns.Size = new System.Drawing.Size(208, 18);
			this.labelGridColumns.TabIndex = 14;
			this.labelGridColumns.Text = " 0 1 2 3 4 5 6 7 8 9";
			// 
			// labelGridRows
			// 
			this.labelGridRows.AutoSize = true;
			this.labelGridRows.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelGridRows.Location = new System.Drawing.Point(184, 178);
			this.labelGridRows.Name = "labelGridRows";
			this.labelGridRows.Size = new System.Drawing.Size(18, 18);
			this.labelGridRows.TabIndex = 15;
			this.labelGridRows.Text = "0";
			// 
			// buttonStartGame
			// 
			this.buttonStartGame.Location = new System.Drawing.Point(255, 117);
			this.buttonStartGame.Name = "buttonStartGame";
			this.buttonStartGame.Size = new System.Drawing.Size(75, 23);
			this.buttonStartGame.TabIndex = 25;
			this.buttonStartGame.Text = "Start Game!";
			this.buttonStartGame.UseVisualStyleBackColor = true;
			this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
			// 
			// labelInstructionsTitle
			// 
			this.labelInstructionsTitle.AutoSize = true;
			this.labelInstructionsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelInstructionsTitle.Location = new System.Drawing.Point(57, 91);
			this.labelInstructionsTitle.Name = "labelInstructionsTitle";
			this.labelInstructionsTitle.Size = new System.Drawing.Size(80, 17);
			this.labelInstructionsTitle.TabIndex = 26;
			this.labelInstructionsTitle.Text = "Instructions";
			// 
			// labelLastGuess
			// 
			this.labelLastGuess.AutoSize = true;
			this.labelLastGuess.Location = new System.Drawing.Point(411, 223);
			this.labelLastGuess.Name = "labelLastGuess";
			this.labelLastGuess.Size = new System.Drawing.Size(61, 13);
			this.labelLastGuess.TabIndex = 27;
			this.labelLastGuess.Text = "Last guess:";
			// 
			// labelGrid
			// 
			this.labelGrid.AutoSize = true;
			this.labelGrid.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelGrid.Location = new System.Drawing.Point(202, 178);
			this.labelGrid.Name = "labelGrid";
			this.labelGrid.Size = new System.Drawing.Size(198, 18);
			this.labelGrid.TabIndex = 28;
			this.labelGrid.Text = "~ ~ ~ ~ ~ ~ ~ ~ ~ ~";
			// 
			// pictureBoxMagnifyingGlass
			// 
			this.pictureBoxMagnifyingGlass.Image = global::FindSampleGame___Cory_Michener.Properties.Resources.MagnifyingGlass;
			this.pictureBoxMagnifyingGlass.Location = new System.Drawing.Point(442, 23);
			this.pictureBoxMagnifyingGlass.Name = "pictureBoxMagnifyingGlass";
			this.pictureBoxMagnifyingGlass.Size = new System.Drawing.Size(128, 128);
			this.pictureBoxMagnifyingGlass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxMagnifyingGlass.TabIndex = 29;
			this.pictureBoxMagnifyingGlass.TabStop = false;
			// 
			// FindSampleGameForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 461);
			this.Controls.Add(this.pictureBoxMagnifyingGlass);
			this.Controls.Add(this.labelGrid);
			this.Controls.Add(this.labelLastGuess);
			this.Controls.Add(this.labelInstructionsTitle);
			this.Controls.Add(this.buttonStartGame);
			this.Controls.Add(this.labelGridRows);
			this.Controls.Add(this.labelGridColumns);
			this.Controls.Add(this.labelTitle);
			this.Controls.Add(this.labelGuessResponse);
			this.Controls.Add(this.textBoxGridSizeRows);
			this.Controls.Add(this.textBoxGridSizeColumns);
			this.Controls.Add(this.labalGridSizeColumns);
			this.Controls.Add(this.labelGridSizeRows);
			this.Controls.Add(this.labelGridSize);
			this.Controls.Add(this.labelInstructions);
			this.Controls.Add(this.textBoxGuessColumn);
			this.Controls.Add(this.textBoxGuessRow);
			this.Controls.Add(this.labelGuessColumn);
			this.Controls.Add(this.labelGuessRow);
			this.Controls.Add(this.buttonSubmitGuess);
			this.Controls.Add(this.labelGuesses);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FindSampleGameForm";
			this.Text = "Find Sample Game";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxMagnifyingGlass)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelGuesses;
		private System.Windows.Forms.Button buttonSubmitGuess;
		private System.Windows.Forms.Label labelGuessRow;
		private System.Windows.Forms.Label labelGuessColumn;
		private System.Windows.Forms.TextBox textBoxGuessRow;
		private System.Windows.Forms.TextBox textBoxGuessColumn;
		private System.Windows.Forms.Label labelInstructions;
		private System.Windows.Forms.Label labelGridSize;
		private System.Windows.Forms.Label labelGridSizeRows;
		private System.Windows.Forms.Label labalGridSizeColumns;
		private System.Windows.Forms.TextBox textBoxGridSizeColumns;
		private System.Windows.Forms.TextBox textBoxGridSizeRows;
		private System.Windows.Forms.Label labelGuessResponse;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.Label labelGridColumns;
		private System.Windows.Forms.Label labelGridRows;
		private System.Windows.Forms.Button buttonStartGame;
		private System.Windows.Forms.Label labelInstructionsTitle;
		private System.Windows.Forms.Label labelLastGuess;
		private System.Windows.Forms.Label labelGrid;
		private System.Windows.Forms.PictureBox pictureBoxMagnifyingGlass;
	}
}

