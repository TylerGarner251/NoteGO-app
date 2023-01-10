using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace NoteGO_app
{
    public partial class NoteForm : Form
    {
        //Converts the datatbale into a variable to easy purpose in calling
        DataTable table;
        public NoteForm()
        {
            InitializeComponent();
        }
        private void NoteForm_Load(object sender, EventArgs e)
        {
            //creates a new database
            table = new DataTable();
            //adds columns to the database and names them
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("Note", typeof(string));

            //note columns become invisiable and title coloumn matchs the databox size
            Table.DataSource = table;
            Table.Columns["Note"].Visible = false;
            Table.Columns["Title"].Width = 169;

            try
            {
                DirectoryInfo d = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + @"\"); //Assuming Test is your Folder

                FileInfo[] Files = d.GetFiles("*.txt"); //Getting Text files
                string tableFileNames = "";

                foreach (FileInfo file in Files)
                {
                    tableFileNames = file.Name;
                    TitleBox.Text = tableFileNames;
                    table.Rows.Add(TitleBox.Text, NotesBox.Text);
                    TitleBox.Clear();
                }

            }
            catch
            {

            }

        }
        private void TitleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NotesBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Newbutton_ButtonClick(object sender, EventArgs e)
        {
            //clears the title text box and note box
            TitleBox.Clear();
            NotesBox.Clear();
        }

        private void SaveButton_ButtonClick(object sender, EventArgs e)
        {
            //addes a new row to the data table and inserts the titlebox and notebox
            string Savepath = AppDomain.CurrentDomain.BaseDirectory + @"\" + TitleBox.Text + ".txt"; // checks the path and saves into that path
            using (FileStream fs = File.Create(Savepath)) { }
            using (StreamWriter writer = new StreamWriter(Savepath))
            {
                writer.WriteLine(NotesBox.Text);
            }
            table.Rows.Add(TitleBox.Text, NotesBox.Text);
            TitleBox.Clear();
            NotesBox.Clear();
        }

        private void ReadButton_ButtonClick(object sender, EventArgs e)
        {
            // checks what is selected in the database and addes the title and notes to the not and title boxes
            int index = Table.CurrentCell.RowIndex;
            if (index > -1)
            {
                String titleVar = table.Rows[index].ItemArray[0].ToString();
                string Savepath = AppDomain.CurrentDomain.BaseDirectory + @"\" + titleVar;
                TitleBox.Text = Path.GetFileName(Savepath);
                NotesBox.Text = File.ReadAllText(Savepath);

            }
        }

        private void DeleteButton_ButtonClick(object sender, EventArgs e)
        {
            // checks what is selected and deletes the data.
            int index = Table.CurrentCell.RowIndex;
            table.Rows[index].Delete();
        }

        private void MenuBar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void NotesLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void VisualButton_ButtonClick(object sender, EventArgs e)
        {

        }

        private void darkModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotesBox.BackColor = Color.FromArgb(0,0,64);
            NotesBox.ForeColor = Color.White;
            TitleBox.BackColor = Color.FromArgb(0, 0, 64);
            TitleBox.ForeColor = Color.White;
            Table.BackgroundColor = Color.FromArgb(0, 0, 64);
            BackgroundCream.Visible = false;
            BackgroundWhite.Visible = false;
            TitleLabel.BackColor = Color.FromArgb(0, 0, 64);
            NotesLabel.BackColor = Color.FromArgb(0, 0, 64);
            label1.BackColor = Color.FromArgb(0, 0, 64);
            TitleLabel.ForeColor = Color.White;
            NotesLabel.ForeColor = Color.White;
            label1.ForeColor = Color.White;
        }

        private void lightModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotesBox.BackColor = Color.LightGray;
            NotesBox.ForeColor = Color.Black;
            TitleBox.BackColor = Color.LightGray;
            TitleBox.ForeColor = Color.Black;
            Table.BackgroundColor = Color.LightGray;
            BackgroundCream.Visible = false;
            BackgroundWhite.Visible = true;
            TitleLabel.BackColor = Color.FromArgb(237, 237, 237);
            NotesLabel.BackColor = Color.FromArgb(237, 237, 237);
            label1.BackColor = Color.FromArgb(237, 237, 237);
            TitleLabel.ForeColor = Color.Black;
            NotesLabel.ForeColor = Color.Black;
            label1.ForeColor = Color.Black;
        }

        private void positnoteModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotesBox.BackColor = Color.PapayaWhip;
            NotesBox.ForeColor = Color.Black;
            TitleBox.BackColor = Color.PapayaWhip;
            TitleBox.ForeColor = Color.Black;
            Table.BackgroundColor = Color.PapayaWhip;
            BackgroundCream.Visible = true;
            BackgroundWhite.Visible = false;
            TitleLabel.BackColor = Color.FromArgb(253,236,166);
            NotesLabel.BackColor = Color.FromArgb(253, 236, 166);
            label1.BackColor = Color.FromArgb(253, 236, 166);
            TitleLabel.ForeColor = Color.Black;
            NotesLabel.ForeColor = Color.Black;
            label1.ForeColor = Color.Black;
        }
    }
}
