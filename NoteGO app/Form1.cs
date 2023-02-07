using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace NoteGO_app
{
    public partial class NoteForm : Form
    {//Converts the datatbale into a variable to easy purpose in calling
        DataTable table;
        public NoteForm()
        {
            InitializeComponent();
        }
        private Properties.Settings set = Properties.Settings.Default;
        private void NoteForm_Load(object sender, EventArgs e)
        {//creates a new database
            table = new DataTable();
            //adds columns to the database and names them
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("Note", typeof(string));
            //note columns become invisiable and title coloumn matchs the databox size
            Table.DataSource = table;
            Table.Columns["Note"].Visible = false;
            Table.Columns["Title"].Width = 169;
            refresh();
        }
        public void refresh()
        {
            // starting the background colour with the correct settings colour on startup
            NotesBox.BackColor = set.ThemeOption;
            TitleBox.BackColor = set.ThemeOption;
            Table.BackgroundColor = set.ThemeOption;
            panel1.BackColor = set.ThemeOption;
            NotesBox.ForeColor = set.FontColour;
            TitleBox.ForeColor = set.FontColour;
            Newbutton.ForeColor = set.FontColour;
            SaveButton.ForeColor = set.FontColour;
            RemoveButton.ForeColor = set.FontColour;
            SettingButton.ForeColor = set.FontColour;
            label1.ForeColor = set.FontColour;

            //adding files to list
            DirectoryInfo root = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + @"\"); //Assuming Test is your Folder
            FileInfo[] Files = root.GetFiles("*.txt"); //Getting Text files
            string tableFileNames = "";

            foreach (FileInfo file in Files)
            {
                tableFileNames = file.Name;
                TitleBox.Text = tableFileNames;
                table.Rows.Add(TitleBox.Text, NotesBox.Text);
                TitleBox.Clear();
            }
        }
        #region Misc Calling
        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e) { }
        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e) { }
        private void TitleBox_TextChanged(object sender, EventArgs e) { }
        private void TitleBox_Enter(object sender, EventArgs e)
        {
            if (TitleBox.Text == "Notes Title:")
            {
                TitleBox.Text = "";
            }
        }
        private void TitleBox_Leave(object sender, EventArgs e)
        {
            if (TitleBox.Text == "")
            {
                TitleBox.Text = "Notes Title:";
            }
        }
        private void NotesBox_TextChanged(object sender, EventArgs e) { }
        private void NotesBox_Enter(object sender, EventArgs e) //placeholder text enter
        {
            if (NotesBox.Text == "Insert Notes:")
            {
                NotesBox.Text = "";
            }
        }
        private void NotesBox_Leave(object sender, EventArgs e) //placeholder text leave
        {
            if (NotesBox.Text == "")
            {
                NotesBox.Text = "Insert Notes:";
            }
        }
        private void label1_Click(object sender, EventArgs e) { }
        #endregion
        #region Button Controlls
        private void Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {// checks what is selected in the database and addes the title and notes to the not and title boxes
            int index = Table.CurrentCell.RowIndex;
            try
            {
                if (index > -1)
                {
                    String titleVar = table.Rows[index].ItemArray[0].ToString();
                    string Savepath = AppDomain.CurrentDomain.BaseDirectory + @"\" + titleVar;
                    TitleBox.Text = Path.GetFileName(Savepath);
                    NotesBox.Text = File.ReadAllText(Savepath);
                    TitleBox.Enabled = false;
                }
            }
            catch
            {
                String titleVar = table.Rows[index].ItemArray[0].ToString();
                string Savepath = AppDomain.CurrentDomain.BaseDirectory + @"\" + titleVar + ".txt";
                TitleBox.Text = Path.GetFileName(Savepath);
                NotesBox.Text = File.ReadAllText(Savepath);
                TitleBox.Enabled = false;
            }
        }
        private void Newbutton_Click(object sender, EventArgs e)
        {
            //clears the title text box and note box
            TitleBox.Clear();
            NotesBox.Clear();
            TitleBox.Enabled = true;
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            string CheckingSavePath = AppDomain.CurrentDomain.BaseDirectory + @"\" + TitleBox.Text;
            if (File.Exists(CheckingSavePath) == true)
            {
                StreamWriter strm = File.CreateText(CheckingSavePath);
                strm.Flush();
                strm.Close();
                File.AppendAllText(CheckingSavePath, NotesBox.Text);
                MessageBox.Show("Saved | The Note " + TitleBox.Text + " was saved", "Saved");
                TitleBox.Clear();
                NotesBox.Clear();
            }
            else if (File.Exists(CheckingSavePath) == false)
            {
                //addes a new row to the data table and inserts the titlebox and notebox
                string Savepath = AppDomain.CurrentDomain.BaseDirectory + @"\" + TitleBox.Text + ".txt"; // checks the path and saves into that path
                using (FileStream fs = File.Create(Savepath)) { }
                File.WriteAllText(Savepath, NotesBox.Text);
                table.Rows.Add(TitleBox.Text, NotesBox.Text);
                MessageBox.Show("Saved | The Note '" + TitleBox.Text + "' was saved", "Saved");
                TitleBox.Clear();
                NotesBox.Clear();
            }
            else
            {
                MessageBox.Show("Error | Cannot save file", "Error");
            }
        }
        private void ReadButton_ButtonClick(object sender, EventArgs e)
        {
            Table_CellContentClick(ReadButton, null);
        }
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Error: There no notes selected");
            }
            else
            {
                int index = Table.CurrentCell.RowIndex;//gets the row index from the list
                String titleVar = table.Rows[index].ItemArray[0].ToString(); //gets the table row name from the index given
                string Savepath = AppDomain.CurrentDomain.BaseDirectory + @"\" + titleVar;
                File.Delete(Savepath);
                string Savepath2 = AppDomain.CurrentDomain.BaseDirectory + @"\" + titleVar + ".txt";
                File.Delete(Savepath2);
                table.Rows[index].Delete();
            }
        }
        private void SettingButton_Click(object sender, EventArgs e)
        {
            settingsForm1.Show();
            settingsForm1.BringToFront();
        }
        #endregion
    }
}
