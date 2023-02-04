using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace NoteGO_app
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void DarkmodeButton_Click(object sender, EventArgs e)
        {
            NoteForm form = new NoteForm();
            form.darkmode();
        }

        private void LightModeButton_Click(object sender, EventArgs e)
        {
            NoteForm form = new NoteForm();
            form.lightMode();
        }

        private void PostitNoteButton_Click(object sender, EventArgs e)
        {
            NoteForm form = new NoteForm();
            form.postitNoteMode();
        }
    }
}
