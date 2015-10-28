namespace DescriptionGenerator
{
	partial class Output
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
			this.txtOutput = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// txtOutput
			// 
			this.txtOutput.AcceptsTab = true;
			this.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtOutput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOutput.Location = new System.Drawing.Point(0, 0);
			this.txtOutput.Name = "txtOutput";
			this.txtOutput.Size = new System.Drawing.Size(744, 361);
			this.txtOutput.TabIndex = 0;
			this.txtOutput.Text = "";
			this.txtOutput.WordWrap = false;
			// 
			// Output
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(744, 361);
			this.Controls.Add(this.txtOutput);
			this.MaximumSize = new System.Drawing.Size(4000, 2000);
			this.MinimumSize = new System.Drawing.Size(760, 0);
			this.Name = "Output";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ShowIcon = false;
			this.Text = "Output";
			this.Load += new System.EventHandler(this.Output_Load);
			this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.RichTextBox txtOutput;
	}
}