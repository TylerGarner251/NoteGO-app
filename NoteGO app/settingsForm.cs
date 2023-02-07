using NoteGO_app.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteGO_app
{
    public partial class settingsForm : UserControl
    {
        public settingsForm()
        {
            InitializeComponent();
        }
        private Properties.Settings set = Properties.Settings.Default;
        private void DarkmodeButton_CheckedChanged(object sender, EventArgs e) { }
        private void LightmodeButton_CheckedChanged(object sender, EventArgs e) { }
        private void Postitnotebutton_CheckedChanged(object sender, EventArgs e) { }
        private void ApplyButtonS_Click(object sender, EventArgs e)
        {
            if (DarkmodeButton.Checked == true)
            {
                set.ThemeOption = Color.FromArgb(64, 64, 64);
                set.FontColour = Color.White;
                set.Save();
                this.Hide();
                this.SendToBack();
                Application.Restart();
            }
            else if (LightmodeButton.Checked == true)
            {
                set.ThemeOption = Color.FromArgb(224, 224, 224);
                set.FontColour = Color.Black;
                set.Save();
                this.Hide();
                this.SendToBack();
                Application.Restart();
            }
            else if (Postitnotebutton.Checked == true)
            {
                set.ThemeOption = Color.FromArgb(255, 225, 192);
                set.FontColour = Color.Black;
                set.Save();
                this.Hide();
                this.SendToBack();
                Application.Restart();
            }

        }
        private void CancelButtonS_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.SendToBack();
        }
    }
}
