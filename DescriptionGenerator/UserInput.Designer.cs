namespace DescriptionGenerator
{
	partial class UserInput
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInput));
			this.rdiSymbolSelect1 = new System.Windows.Forms.RadioButton();
			this.rdiSymbolSelect2 = new System.Windows.Forms.RadioButton();
			this.rdiSymbolSelect3 = new System.Windows.Forms.RadioButton();
			this.grpSymbolSelect = new System.Windows.Forms.GroupBox();
			this.txtCustomSymbol = new System.Windows.Forms.TextBox();
			this.rdiSymbolSelect5 = new System.Windows.Forms.RadioButton();
			this.rdiSymbolSelect4 = new System.Windows.Forms.RadioButton();
			this.lblProgramName = new System.Windows.Forms.Label();
			this.lblAuthorName = new System.Windows.Forms.Label();
			this.lblProjectName = new System.Windows.Forms.Label();
			this.txtProgramName = new System.Windows.Forms.TextBox();
			this.txtProjectname = new System.Windows.Forms.TextBox();
			this.txtAuthorName = new System.Windows.Forms.TextBox();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.lblStatus = new System.Windows.Forms.Label();
			this.grpSymbolSelect.SuspendLayout();
			this.SuspendLayout();
			// 
			// rdiSymbolSelect1
			// 
			this.rdiSymbolSelect1.AutoSize = true;
			this.rdiSymbolSelect1.Location = new System.Drawing.Point(5, 21);
			this.rdiSymbolSelect1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rdiSymbolSelect1.Name = "rdiSymbolSelect1";
			this.rdiSymbolSelect1.Size = new System.Drawing.Size(65, 21);
			this.rdiSymbolSelect1.TabIndex = 0;
			this.rdiSymbolSelect1.TabStop = true;
			this.rdiSymbolSelect1.Tag = "=";
			this.rdiSymbolSelect1.Text = "Equal";
			this.rdiSymbolSelect1.UseVisualStyleBackColor = true;
			// 
			// rdiSymbolSelect2
			// 
			this.rdiSymbolSelect2.AutoSize = true;
			this.rdiSymbolSelect2.Location = new System.Drawing.Point(5, 48);
			this.rdiSymbolSelect2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rdiSymbolSelect2.Name = "rdiSymbolSelect2";
			this.rdiSymbolSelect2.Size = new System.Drawing.Size(62, 21);
			this.rdiSymbolSelect2.TabIndex = 1;
			this.rdiSymbolSelect2.TabStop = true;
			this.rdiSymbolSelect2.Tag = "-";
			this.rdiSymbolSelect2.Text = "Dash";
			this.rdiSymbolSelect2.UseVisualStyleBackColor = true;
			// 
			// rdiSymbolSelect3
			// 
			this.rdiSymbolSelect3.AutoSize = true;
			this.rdiSymbolSelect3.Location = new System.Drawing.Point(5, 75);
			this.rdiSymbolSelect3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rdiSymbolSelect3.Name = "rdiSymbolSelect3";
			this.rdiSymbolSelect3.Size = new System.Drawing.Size(60, 21);
			this.rdiSymbolSelect3.TabIndex = 2;
			this.rdiSymbolSelect3.TabStop = true;
			this.rdiSymbolSelect3.Tag = "~";
			this.rdiSymbolSelect3.Text = "Tilde";
			this.rdiSymbolSelect3.UseVisualStyleBackColor = true;
			// 
			// grpSymbolSelect
			// 
			this.grpSymbolSelect.Controls.Add(this.txtCustomSymbol);
			this.grpSymbolSelect.Controls.Add(this.rdiSymbolSelect5);
			this.grpSymbolSelect.Controls.Add(this.rdiSymbolSelect4);
			this.grpSymbolSelect.Controls.Add(this.rdiSymbolSelect1);
			this.grpSymbolSelect.Controls.Add(this.rdiSymbolSelect3);
			this.grpSymbolSelect.Controls.Add(this.rdiSymbolSelect2);
			this.grpSymbolSelect.Location = new System.Drawing.Point(12, 12);
			this.grpSymbolSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.grpSymbolSelect.Name = "grpSymbolSelect";
			this.grpSymbolSelect.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.grpSymbolSelect.Size = new System.Drawing.Size(191, 101);
			this.grpSymbolSelect.TabIndex = 3;
			this.grpSymbolSelect.TabStop = false;
			this.grpSymbolSelect.Text = "Formatting Filler Character";
			// 
			// txtCustomSymbol
			// 
			this.txtCustomSymbol.Location = new System.Drawing.Point(83, 74);
			this.txtCustomSymbol.Name = "txtCustomSymbol";
			this.txtCustomSymbol.Size = new System.Drawing.Size(100, 22);
			this.txtCustomSymbol.TabIndex = 5;
			// 
			// rdiSymbolSelect5
			// 
			this.rdiSymbolSelect5.AutoSize = true;
			this.rdiSymbolSelect5.Location = new System.Drawing.Point(83, 48);
			this.rdiSymbolSelect5.Name = "rdiSymbolSelect5";
			this.rdiSymbolSelect5.Size = new System.Drawing.Size(76, 21);
			this.rdiSymbolSelect5.TabIndex = 4;
			this.rdiSymbolSelect5.TabStop = true;
			this.rdiSymbolSelect5.Tag = "custom";
			this.rdiSymbolSelect5.Text = "Custom";
			this.rdiSymbolSelect5.UseVisualStyleBackColor = true;
			// 
			// rdiSymbolSelect4
			// 
			this.rdiSymbolSelect4.AutoSize = true;
			this.rdiSymbolSelect4.Location = new System.Drawing.Point(83, 21);
			this.rdiSymbolSelect4.Name = "rdiSymbolSelect4";
			this.rdiSymbolSelect4.Size = new System.Drawing.Size(79, 21);
			this.rdiSymbolSelect4.TabIndex = 3;
			this.rdiSymbolSelect4.TabStop = true;
			this.rdiSymbolSelect4.Tag = "*";
			this.rdiSymbolSelect4.Text = "Asterisk";
			this.rdiSymbolSelect4.UseVisualStyleBackColor = true;
			// 
			// lblProgramName
			// 
			this.lblProgramName.AutoSize = true;
			this.lblProgramName.Location = new System.Drawing.Point(209, 28);
			this.lblProgramName.Name = "lblProgramName";
			this.lblProgramName.Size = new System.Drawing.Size(103, 17);
			this.lblProgramName.TabIndex = 4;
			this.lblProgramName.Text = "Program Name";
			// 
			// lblAuthorName
			// 
			this.lblAuthorName.AutoSize = true;
			this.lblAuthorName.Location = new System.Drawing.Point(209, 86);
			this.lblAuthorName.Name = "lblAuthorName";
			this.lblAuthorName.Size = new System.Drawing.Size(91, 17);
			this.lblAuthorName.TabIndex = 5;
			this.lblAuthorName.Text = "Author Name";
			// 
			// lblProjectName
			// 
			this.lblProjectName.AutoSize = true;
			this.lblProjectName.Location = new System.Drawing.Point(209, 57);
			this.lblProjectName.Name = "lblProjectName";
			this.lblProjectName.Size = new System.Drawing.Size(93, 17);
			this.lblProjectName.TabIndex = 6;
			this.lblProjectName.Text = "Project Name";
			// 
			// txtProgramName
			// 
			this.txtProgramName.Location = new System.Drawing.Point(323, 25);
			this.txtProgramName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtProgramName.Name = "txtProgramName";
			this.txtProgramName.Size = new System.Drawing.Size(193, 22);
			this.txtProgramName.TabIndex = 7;
			// 
			// txtProjectname
			// 
			this.txtProjectname.Location = new System.Drawing.Point(323, 53);
			this.txtProjectname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtProjectname.Name = "txtProjectname";
			this.txtProjectname.Size = new System.Drawing.Size(193, 22);
			this.txtProjectname.TabIndex = 8;
			// 
			// txtAuthorName
			// 
			this.txtAuthorName.Location = new System.Drawing.Point(323, 81);
			this.txtAuthorName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtAuthorName.Name = "txtAuthorName";
			this.txtAuthorName.Size = new System.Drawing.Size(193, 22);
			this.txtAuthorName.TabIndex = 9;
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(12, 119);
			this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(504, 189);
			this.txtDescription.TabIndex = 10;
			// 
			// btnGenerate
			// 
			this.btnGenerate.Location = new System.Drawing.Point(304, 315);
			this.btnGenerate.Margin = new System.Windows.Forms.Padding(4);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(213, 28);
			this.btnGenerate.TabIndex = 11;
			this.btnGenerate.Text = "Generate Definition Header";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new System.Drawing.Point(14, 321);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(214, 17);
			this.lblStatus.TabIndex = 12;
			this.lblStatus.Text = "Clipboard Contents set to Output";
			// 
			// UserInput
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(528, 355);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.btnGenerate);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.txtAuthorName);
			this.Controls.Add(this.txtProjectname);
			this.Controls.Add(this.txtProgramName);
			this.Controls.Add(this.lblProjectName);
			this.Controls.Add(this.lblAuthorName);
			this.Controls.Add(this.lblProgramName);
			this.Controls.Add(this.grpSymbolSelect);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MaximizeBox = false;
			this.Name = "UserInput";
			this.Text = "Generate Program Definition Header";
			this.grpSymbolSelect.ResumeLayout(false);
			this.grpSymbolSelect.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton rdiSymbolSelect1;
		private System.Windows.Forms.RadioButton rdiSymbolSelect2;
		private System.Windows.Forms.RadioButton rdiSymbolSelect3;
		private System.Windows.Forms.GroupBox grpSymbolSelect;
		private System.Windows.Forms.Label lblProgramName;
		private System.Windows.Forms.Label lblAuthorName;
		private System.Windows.Forms.Label lblProjectName;
		private System.Windows.Forms.TextBox txtProgramName;
		private System.Windows.Forms.TextBox txtProjectname;
		private System.Windows.Forms.TextBox txtAuthorName;
		private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.TextBox txtCustomSymbol;
		private System.Windows.Forms.RadioButton rdiSymbolSelect5;
		private System.Windows.Forms.RadioButton rdiSymbolSelect4;
		private System.Windows.Forms.Label lblStatus;
    }
}

