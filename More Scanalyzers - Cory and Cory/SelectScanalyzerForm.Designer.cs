namespace More_Scanalyzers___Cory_and_Cory
{
	partial class SelectScanalyzerForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectScanalyzerForm));
			this.radioButtonFingerPrint = new System.Windows.Forms.RadioButton();
			this.pictureBoxFingerprint = new System.Windows.Forms.PictureBox();
			this.pictureBoxBloodStain = new System.Windows.Forms.PictureBox();
			this.radioButtonBloodStain = new System.Windows.Forms.RadioButton();
			this.radioButtonHairFollicle = new System.Windows.Forms.RadioButton();
			this.pictureBoxHairFollicle = new System.Windows.Forms.PictureBox();
			this.labelSelectScanalyzer = new System.Windows.Forms.Label();
			this.buttonConfirm = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxFingerprint)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxBloodStain)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxHairFollicle)).BeginInit();
			this.SuspendLayout();
			// 
			// radioButtonFingerPrint
			// 
			this.radioButtonFingerPrint.AutoSize = true;
			this.radioButtonFingerPrint.Checked = true;
			this.radioButtonFingerPrint.Location = new System.Drawing.Point(55, 167);
			this.radioButtonFingerPrint.Name = "radioButtonFingerPrint";
			this.radioButtonFingerPrint.Size = new System.Drawing.Size(74, 17);
			this.radioButtonFingerPrint.TabIndex = 0;
			this.radioButtonFingerPrint.TabStop = true;
			this.radioButtonFingerPrint.Text = "Fingerprint";
			this.radioButtonFingerPrint.UseVisualStyleBackColor = true;
			this.radioButtonFingerPrint.CheckedChanged += new System.EventHandler(this.radioButtonFingerPrint_CheckedChanged);
			// 
			// pictureBoxFingerprint
			// 
			this.pictureBoxFingerprint.Image = global::More_Scanalyzers___Cory_and_Cory.Properties.Resources.fingerprint1;
			this.pictureBoxFingerprint.Location = new System.Drawing.Point(42, 61);
			this.pictureBoxFingerprint.Name = "pictureBoxFingerprint";
			this.pictureBoxFingerprint.Size = new System.Drawing.Size(100, 100);
			this.pictureBoxFingerprint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxFingerprint.TabIndex = 1;
			this.pictureBoxFingerprint.TabStop = false;
			// 
			// pictureBoxBloodStain
			// 
			this.pictureBoxBloodStain.Image = global::More_Scanalyzers___Cory_and_Cory.Properties.Resources.bloodStain1;
			this.pictureBoxBloodStain.Location = new System.Drawing.Point(177, 61);
			this.pictureBoxBloodStain.Name = "pictureBoxBloodStain";
			this.pictureBoxBloodStain.Size = new System.Drawing.Size(100, 100);
			this.pictureBoxBloodStain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxBloodStain.TabIndex = 2;
			this.pictureBoxBloodStain.TabStop = false;
			// 
			// radioButtonBloodStain
			// 
			this.radioButtonBloodStain.AutoSize = true;
			this.radioButtonBloodStain.Location = new System.Drawing.Point(188, 167);
			this.radioButtonBloodStain.Name = "radioButtonBloodStain";
			this.radioButtonBloodStain.Size = new System.Drawing.Size(79, 17);
			this.radioButtonBloodStain.TabIndex = 3;
			this.radioButtonBloodStain.Text = "Blood Stain";
			this.radioButtonBloodStain.UseVisualStyleBackColor = true;
			this.radioButtonBloodStain.CheckedChanged += new System.EventHandler(this.radioButtonBloodStain_CheckedChanged);
			// 
			// radioButtonHairFollicle
			// 
			this.radioButtonHairFollicle.AutoSize = true;
			this.radioButtonHairFollicle.Location = new System.Drawing.Point(323, 167);
			this.radioButtonHairFollicle.Name = "radioButtonHairFollicle";
			this.radioButtonHairFollicle.Size = new System.Drawing.Size(79, 17);
			this.radioButtonHairFollicle.TabIndex = 5;
			this.radioButtonHairFollicle.Text = "Hair Follicle";
			this.radioButtonHairFollicle.UseVisualStyleBackColor = true;
			this.radioButtonHairFollicle.CheckedChanged += new System.EventHandler(this.radioButtonHairFollicle_CheckedChanged);
			// 
			// pictureBoxHairFollicle
			// 
			this.pictureBoxHairFollicle.Image = global::More_Scanalyzers___Cory_and_Cory.Properties.Resources.hairFollicle1;
			this.pictureBoxHairFollicle.Location = new System.Drawing.Point(312, 61);
			this.pictureBoxHairFollicle.Name = "pictureBoxHairFollicle";
			this.pictureBoxHairFollicle.Size = new System.Drawing.Size(100, 100);
			this.pictureBoxHairFollicle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxHairFollicle.TabIndex = 4;
			this.pictureBoxHairFollicle.TabStop = false;
			// 
			// labelSelectScanalyzer
			// 
			this.labelSelectScanalyzer.AutoSize = true;
			this.labelSelectScanalyzer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelSelectScanalyzer.Location = new System.Drawing.Point(55, 19);
			this.labelSelectScanalyzer.Name = "labelSelectScanalyzer";
			this.labelSelectScanalyzer.Size = new System.Drawing.Size(345, 26);
			this.labelSelectScanalyzer.TabIndex = 6;
			this.labelSelectScanalyzer.Text = "Please select a Scanalyzer to use.";
			// 
			// buttonConfirm
			// 
			this.buttonConfirm.Location = new System.Drawing.Point(177, 195);
			this.buttonConfirm.Name = "buttonConfirm";
			this.buttonConfirm.Size = new System.Drawing.Size(100, 50);
			this.buttonConfirm.TabIndex = 7;
			this.buttonConfirm.Text = "Confirm";
			this.buttonConfirm.UseVisualStyleBackColor = true;
			this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
			// 
			// SelectScanalyzerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(455, 257);
			this.Controls.Add(this.buttonConfirm);
			this.Controls.Add(this.labelSelectScanalyzer);
			this.Controls.Add(this.radioButtonHairFollicle);
			this.Controls.Add(this.pictureBoxHairFollicle);
			this.Controls.Add(this.radioButtonBloodStain);
			this.Controls.Add(this.pictureBoxBloodStain);
			this.Controls.Add(this.pictureBoxFingerprint);
			this.Controls.Add(this.radioButtonFingerPrint);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "SelectScanalyzerForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Select Scanalyzer";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxFingerprint)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxBloodStain)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxHairFollicle)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton radioButtonFingerPrint;
		private System.Windows.Forms.PictureBox pictureBoxFingerprint;
		private System.Windows.Forms.PictureBox pictureBoxBloodStain;
		private System.Windows.Forms.RadioButton radioButtonBloodStain;
		private System.Windows.Forms.RadioButton radioButtonHairFollicle;
		private System.Windows.Forms.PictureBox pictureBoxHairFollicle;
		private System.Windows.Forms.Label labelSelectScanalyzer;
		private System.Windows.Forms.Button buttonConfirm;
	}
}