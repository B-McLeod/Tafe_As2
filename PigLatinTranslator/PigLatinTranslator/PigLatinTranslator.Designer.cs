namespace PigLatinTranslator
{
	partial class frmPigLatinTranslator
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
			this.lblEnglish = new System.Windows.Forms.Label();
			this.txtEnglish = new System.Windows.Forms.TextBox();
			this.txtPigLatin = new System.Windows.Forms.TextBox();
			this.lblPigLatin = new System.Windows.Forms.Label();
			this.btnTranslate = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.lblCheck = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblEnglish
			// 
			this.lblEnglish.AutoSize = true;
			this.lblEnglish.Location = new System.Drawing.Point(9, 14);
			this.lblEnglish.Name = "lblEnglish";
			this.lblEnglish.Size = new System.Drawing.Size(116, 13);
			this.lblEnglish.TabIndex = 0;
			this.lblEnglish.Text = "Enter English text here:";
			// 
			// txtEnglish
			// 
			this.txtEnglish.Location = new System.Drawing.Point(12, 30);
			this.txtEnglish.Multiline = true;
			this.txtEnglish.Name = "txtEnglish";
			this.txtEnglish.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtEnglish.Size = new System.Drawing.Size(240, 71);
			this.txtEnglish.TabIndex = 1;
			// 
			// txtPigLatin
			// 
			this.txtPigLatin.Location = new System.Drawing.Point(12, 131);
			this.txtPigLatin.Multiline = true;
			this.txtPigLatin.Name = "txtPigLatin";
			this.txtPigLatin.ReadOnly = true;
			this.txtPigLatin.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtPigLatin.Size = new System.Drawing.Size(240, 71);
			this.txtPigLatin.TabIndex = 0;
			this.txtPigLatin.TabStop = false;
			// 
			// lblPigLatin
			// 
			this.lblPigLatin.AutoSize = true;
			this.lblPigLatin.Location = new System.Drawing.Point(9, 115);
			this.lblPigLatin.Name = "lblPigLatin";
			this.lblPigLatin.Size = new System.Drawing.Size(102, 13);
			this.lblPigLatin.TabIndex = 0;
			this.lblPigLatin.Text = "Pig Latin translation:";
			// 
			// btnTranslate
			// 
			this.btnTranslate.Location = new System.Drawing.Point(13, 209);
			this.btnTranslate.Name = "btnTranslate";
			this.btnTranslate.Size = new System.Drawing.Size(75, 23);
			this.btnTranslate.TabIndex = 2;
			this.btnTranslate.Text = "&Translate";
			this.btnTranslate.UseVisualStyleBackColor = true;
			this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(95, 209);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 23);
			this.btnClear.TabIndex = 3;
			this.btnClear.Text = "&Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnExit
			// 
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnExit.Location = new System.Drawing.Point(177, 209);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 4;
			this.btnExit.Text = "E&xit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// lblCheck
			// 
			this.lblCheck.AutoSize = true;
			this.lblCheck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblCheck.Location = new System.Drawing.Point(9, 235);
			this.lblCheck.Name = "lblCheck";
			this.lblCheck.Size = new System.Drawing.Size(77, 13);
			this.lblCheck.TabIndex = 5;
			this.lblCheck.Text = "Check Status: ";
			// 
			// frmPigLatinTranslator
			// 
			this.AcceptButton = this.btnTranslate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnExit;
			this.ClientSize = new System.Drawing.Size(271, 254);
			this.Controls.Add(this.lblCheck);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnTranslate);
			this.Controls.Add(this.txtPigLatin);
			this.Controls.Add(this.lblPigLatin);
			this.Controls.Add(this.txtEnglish);
			this.Controls.Add(this.lblEnglish);
			this.Name = "frmPigLatinTranslator";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pig Latin Translator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblEnglish;
		private System.Windows.Forms.TextBox txtEnglish;
		private System.Windows.Forms.TextBox txtPigLatin;
		private System.Windows.Forms.Label lblPigLatin;
		private System.Windows.Forms.Button btnTranslate;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label lblCheck;
	}
}

