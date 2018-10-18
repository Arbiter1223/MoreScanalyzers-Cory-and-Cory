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
			this.pictureBoxScanner = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxScanner)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxScanner
			// 
			this.pictureBoxScanner.Image = global::More_Scanalyzers___Cory_and_Cory.Properties.Resources.SubnauticaScanner;
			this.pictureBoxScanner.Location = new System.Drawing.Point(12, 12);
			this.pictureBoxScanner.Name = "pictureBoxScanner";
			this.pictureBoxScanner.Size = new System.Drawing.Size(54, 54);
			this.pictureBoxScanner.TabIndex = 0;
			this.pictureBoxScanner.TabStop = false;
			// 
			// MoreScanalyzersForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pictureBoxScanner);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MoreScanalyzersForm";
			this.Text = "More Scanalyzers!";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxScanner)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxScanner;
	}
}

