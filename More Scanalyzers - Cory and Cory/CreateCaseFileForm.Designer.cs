namespace More_Scanalyzers___Cory_and_Cory
{
	partial class CreateCaseFileForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateCaseFileForm));
			this.labelCaseNumber = new System.Windows.Forms.Label();
			this.textBoxCaseNumber = new System.Windows.Forms.TextBox();
			this.textBoxNumberOfRows = new System.Windows.Forms.TextBox();
			this.labelNumberOfRows = new System.Windows.Forms.Label();
			this.textBoxNumberOfColumns = new System.Windows.Forms.TextBox();
			this.labelNumberOfColumns = new System.Windows.Forms.Label();
			this.textBoxNumberOfSamples = new System.Windows.Forms.TextBox();
			this.labelNumberOfSamples = new System.Windows.Forms.Label();
			this.buttonSaveCaseFile = new System.Windows.Forms.Button();
			this.buttonRandomizeCaseNumber = new System.Windows.Forms.Button();
			this.buttonRandomizeNumberOfRows = new System.Windows.Forms.Button();
			this.buttonRandomizeNumberOfColumns = new System.Windows.Forms.Button();
			this.buttonRandomizeNumberOfSamples = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelCaseNumber
			// 
			this.labelCaseNumber.AutoSize = true;
			this.labelCaseNumber.Location = new System.Drawing.Point(56, 21);
			this.labelCaseNumber.Name = "labelCaseNumber";
			this.labelCaseNumber.Size = new System.Drawing.Size(71, 13);
			this.labelCaseNumber.TabIndex = 0;
			this.labelCaseNumber.Text = "Case Number";
			// 
			// textBoxCaseNumber
			// 
			this.textBoxCaseNumber.Location = new System.Drawing.Point(59, 37);
			this.textBoxCaseNumber.MaxLength = 4;
			this.textBoxCaseNumber.Name = "textBoxCaseNumber";
			this.textBoxCaseNumber.Size = new System.Drawing.Size(129, 20);
			this.textBoxCaseNumber.TabIndex = 1;
			this.textBoxCaseNumber.Text = "0000";
			this.textBoxCaseNumber.TextChanged += new System.EventHandler(this.textBoxCaseNumber_TextChanged);
			// 
			// textBoxNumberOfRows
			// 
			this.textBoxNumberOfRows.Location = new System.Drawing.Point(59, 89);
			this.textBoxNumberOfRows.MaxLength = 2;
			this.textBoxNumberOfRows.Name = "textBoxNumberOfRows";
			this.textBoxNumberOfRows.Size = new System.Drawing.Size(129, 20);
			this.textBoxNumberOfRows.TabIndex = 3;
			this.textBoxNumberOfRows.Text = "5";
			this.textBoxNumberOfRows.TextChanged += new System.EventHandler(this.textBoxNumberOfRows_TextChanged);
			// 
			// labelNumberOfRows
			// 
			this.labelNumberOfRows.AutoSize = true;
			this.labelNumberOfRows.Location = new System.Drawing.Point(56, 73);
			this.labelNumberOfRows.Name = "labelNumberOfRows";
			this.labelNumberOfRows.Size = new System.Drawing.Size(119, 13);
			this.labelNumberOfRows.TabIndex = 2;
			this.labelNumberOfRows.Text = "Number of Rows in Grid";
			// 
			// textBoxNumberOfColumns
			// 
			this.textBoxNumberOfColumns.Location = new System.Drawing.Point(59, 141);
			this.textBoxNumberOfColumns.MaxLength = 2;
			this.textBoxNumberOfColumns.Name = "textBoxNumberOfColumns";
			this.textBoxNumberOfColumns.Size = new System.Drawing.Size(129, 20);
			this.textBoxNumberOfColumns.TabIndex = 5;
			this.textBoxNumberOfColumns.Text = "5";
			this.textBoxNumberOfColumns.TextChanged += new System.EventHandler(this.textBoxNumberOfColumns_TextChanged);
			// 
			// labelNumberOfColumns
			// 
			this.labelNumberOfColumns.AutoSize = true;
			this.labelNumberOfColumns.Location = new System.Drawing.Point(56, 125);
			this.labelNumberOfColumns.Name = "labelNumberOfColumns";
			this.labelNumberOfColumns.Size = new System.Drawing.Size(132, 13);
			this.labelNumberOfColumns.TabIndex = 4;
			this.labelNumberOfColumns.Text = "Number of Columns in Grid";
			// 
			// textBoxNumberOfSamples
			// 
			this.textBoxNumberOfSamples.Location = new System.Drawing.Point(59, 193);
			this.textBoxNumberOfSamples.MaxLength = 1;
			this.textBoxNumberOfSamples.Name = "textBoxNumberOfSamples";
			this.textBoxNumberOfSamples.Size = new System.Drawing.Size(129, 20);
			this.textBoxNumberOfSamples.TabIndex = 7;
			this.textBoxNumberOfSamples.Text = "2";
			this.textBoxNumberOfSamples.TextChanged += new System.EventHandler(this.textBoxNumberOfSamples_TextChanged);
			// 
			// labelNumberOfSamples
			// 
			this.labelNumberOfSamples.AutoSize = true;
			this.labelNumberOfSamples.Location = new System.Drawing.Point(56, 177);
			this.labelNumberOfSamples.Name = "labelNumberOfSamples";
			this.labelNumberOfSamples.Size = new System.Drawing.Size(99, 13);
			this.labelNumberOfSamples.TabIndex = 6;
			this.labelNumberOfSamples.Text = "Number of Samples";
			// 
			// buttonSaveCaseFile
			// 
			this.buttonSaveCaseFile.Location = new System.Drawing.Point(115, 236);
			this.buttonSaveCaseFile.Name = "buttonSaveCaseFile";
			this.buttonSaveCaseFile.Size = new System.Drawing.Size(100, 50);
			this.buttonSaveCaseFile.TabIndex = 10;
			this.buttonSaveCaseFile.Text = "Save Case File";
			this.buttonSaveCaseFile.UseVisualStyleBackColor = true;
			this.buttonSaveCaseFile.Click += new System.EventHandler(this.buttonSaveCaseFile_Click);
			// 
			// buttonRandomizeCaseNumber
			// 
			this.buttonRandomizeCaseNumber.Location = new System.Drawing.Point(200, 35);
			this.buttonRandomizeCaseNumber.Name = "buttonRandomizeCaseNumber";
			this.buttonRandomizeCaseNumber.Size = new System.Drawing.Size(75, 23);
			this.buttonRandomizeCaseNumber.TabIndex = 11;
			this.buttonRandomizeCaseNumber.Text = "Randomize";
			this.buttonRandomizeCaseNumber.UseVisualStyleBackColor = true;
			this.buttonRandomizeCaseNumber.Click += new System.EventHandler(this.buttonRandomizeCaseNumber_Click);
			// 
			// buttonRandomizeNumberOfRows
			// 
			this.buttonRandomizeNumberOfRows.Location = new System.Drawing.Point(200, 87);
			this.buttonRandomizeNumberOfRows.Name = "buttonRandomizeNumberOfRows";
			this.buttonRandomizeNumberOfRows.Size = new System.Drawing.Size(75, 23);
			this.buttonRandomizeNumberOfRows.TabIndex = 12;
			this.buttonRandomizeNumberOfRows.Text = "Randomize";
			this.buttonRandomizeNumberOfRows.UseVisualStyleBackColor = true;
			this.buttonRandomizeNumberOfRows.Click += new System.EventHandler(this.buttonRandomizeNumberOfRows_Click);
			// 
			// buttonRandomizeNumberOfColumns
			// 
			this.buttonRandomizeNumberOfColumns.Location = new System.Drawing.Point(200, 139);
			this.buttonRandomizeNumberOfColumns.Name = "buttonRandomizeNumberOfColumns";
			this.buttonRandomizeNumberOfColumns.Size = new System.Drawing.Size(75, 23);
			this.buttonRandomizeNumberOfColumns.TabIndex = 13;
			this.buttonRandomizeNumberOfColumns.Text = "Randomize";
			this.buttonRandomizeNumberOfColumns.UseVisualStyleBackColor = true;
			this.buttonRandomizeNumberOfColumns.Click += new System.EventHandler(this.buttonRandomizeNumberOfColumns_Click);
			// 
			// buttonRandomizeNumberOfSamples
			// 
			this.buttonRandomizeNumberOfSamples.Location = new System.Drawing.Point(200, 191);
			this.buttonRandomizeNumberOfSamples.Name = "buttonRandomizeNumberOfSamples";
			this.buttonRandomizeNumberOfSamples.Size = new System.Drawing.Size(75, 23);
			this.buttonRandomizeNumberOfSamples.TabIndex = 14;
			this.buttonRandomizeNumberOfSamples.Text = "Randomize";
			this.buttonRandomizeNumberOfSamples.UseVisualStyleBackColor = true;
			this.buttonRandomizeNumberOfSamples.Click += new System.EventHandler(this.buttonRandomizeNumberOfSamples_Click);
			// 
			// CreateCaseFileForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(330, 307);
			this.Controls.Add(this.buttonRandomizeNumberOfSamples);
			this.Controls.Add(this.buttonRandomizeNumberOfColumns);
			this.Controls.Add(this.buttonRandomizeNumberOfRows);
			this.Controls.Add(this.buttonRandomizeCaseNumber);
			this.Controls.Add(this.buttonSaveCaseFile);
			this.Controls.Add(this.textBoxNumberOfSamples);
			this.Controls.Add(this.labelNumberOfSamples);
			this.Controls.Add(this.textBoxNumberOfColumns);
			this.Controls.Add(this.labelNumberOfColumns);
			this.Controls.Add(this.textBoxNumberOfRows);
			this.Controls.Add(this.labelNumberOfRows);
			this.Controls.Add(this.textBoxCaseNumber);
			this.Controls.Add(this.labelCaseNumber);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "CreateCaseFileForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "New Case File";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelCaseNumber;
		private System.Windows.Forms.TextBox textBoxCaseNumber;
		private System.Windows.Forms.TextBox textBoxNumberOfRows;
		private System.Windows.Forms.Label labelNumberOfRows;
		private System.Windows.Forms.TextBox textBoxNumberOfColumns;
		private System.Windows.Forms.Label labelNumberOfColumns;
		private System.Windows.Forms.TextBox textBoxNumberOfSamples;
		private System.Windows.Forms.Label labelNumberOfSamples;
		private System.Windows.Forms.Button buttonSaveCaseFile;
		private System.Windows.Forms.Button buttonRandomizeCaseNumber;
		private System.Windows.Forms.Button buttonRandomizeNumberOfRows;
		private System.Windows.Forms.Button buttonRandomizeNumberOfColumns;
		private System.Windows.Forms.Button buttonRandomizeNumberOfSamples;
	}
}