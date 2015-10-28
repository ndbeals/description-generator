using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace DescriptionGenerator
{
    
	public partial class UserInput : Form
	{

		public UserInput()
		{
			InitializeComponent();
		}

		public string getFillerCharacter()
		{
			var checkedButton = grpSymbolSelect.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
			string ret = checkedButton.Tag.ToString();

			if (ret == "custom")
			{
				ret = txtCustomSymbol.Text;
			}

			return ret;
		}


        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Description fileHeader = new Description(txtProgramName.Text,txtProgramName.Text,txtAuthorName.Text,txtDescription.Text);
            fileHeader.GenerateOutput( this.getFillerCharacter() );

            Clipboard.SetText( fileHeader.Output );

            lblStatus.ForeColor = SystemColors.ControlText;

			Output popup = new Output();
			popup.Show();
			popup.txtOutput.Text = fileHeader.Output;
			

            Timer fadeTimer = new Timer();
            int i = 0;

            fadeTimer.Interval = 1500;
            fadeTimer.Tick += (sa, aeaa) =>
            {
				fadeTimer.Interval = 10;
				i++;

				lblStatus.ForeColor = Program.Lerp(SystemColors.ControlText, SystemColors.Control, (float)i / 100.0f);

				lblStatus.Invalidate();
                
                if (i == 100 )
                {
                    fadeTimer.Stop();
                }
            };

            fadeTimer.Start();
        }


        private void rdiSymbolSelect5_CheckedChanged(object sender, EventArgs e)
        {
            rdiSymbolSelect5.Tag = txtCustomSymbol.Text;
        }
    }
}
