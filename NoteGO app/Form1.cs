﻿using System;
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
    {//Converts the datatbale into a variable to easy purpose in calling
        DataTable table;
        public NoteForm()
        {
            InitializeComponent();
        }
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
            TitleBox.Enabled = true;
        }
        private void SaveButton_ButtonClick(object sender, EventArgs e)
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
            else if(File.Exists(CheckingSavePath) == false)
            {
                //addes a new row to the data table and inserts the titlebox and notebox
                string Savepath = AppDomain.CurrentDomain.BaseDirectory + @"\" + TitleBox.Text + ".txt"; // checks the path and saves into that path
                using (FileStream fs = File.Create(Savepath)) { }
                using (StreamWriter writer = new StreamWriter(Savepath))
                {
                    writer.WriteLine(NotesBox.Text);
                }
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
        private void DeleteButton_ButtonClick(object sender, EventArgs e)
        {
            // checks what is selected and deletes the data.
            int index = Table.CurrentCell.RowIndex;
            String titleVar = table.Rows[index].ItemArray[0].ToString();
            string Savepath = AppDomain.CurrentDomain.BaseDirectory + @"\" + titleVar;
            File.Delete(Savepath);
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
        private void ColourSets(int ForeColorRGB1, int ForeColorRGB2, int ForeColorRGB3,int BackColorRGB1,int BackColorRGB2,int BackColorRGB3, int WidgetBackColorRGB1, int WidgetBackColorRGB2, int WidgetBackColorRGB3, bool imageBool1, bool imageBool2)
        {
            //background colours
            NotesBox.BackColor = Color.FromArgb(WidgetBackColorRGB1, WidgetBackColorRGB2, WidgetBackColorRGB3);
            TitleBox.BackColor = Color.FromArgb(WidgetBackColorRGB1, WidgetBackColorRGB2, WidgetBackColorRGB3);
            TitleLabel.BackColor = Color.FromArgb(BackColorRGB1, BackColorRGB2, BackColorRGB3);
            NotesLabel.BackColor = Color.FromArgb(BackColorRGB1, BackColorRGB2, BackColorRGB3);
            label1.BackColor = Color.FromArgb(BackColorRGB1, BackColorRGB2, BackColorRGB3);
            Table.BackgroundColor = Color.FromArgb(WidgetBackColorRGB1, WidgetBackColorRGB2, WidgetBackColorRGB3);
            //Text colours
            NotesBox.ForeColor = Color.FromArgb(ForeColorRGB1, ForeColorRGB2, ForeColorRGB3);
            TitleBox.ForeColor = Color.FromArgb(ForeColorRGB1, ForeColorRGB2, ForeColorRGB3);
            TitleLabel.ForeColor = Color.FromArgb(ForeColorRGB1, ForeColorRGB2, ForeColorRGB3);
            NotesLabel.ForeColor = Color.FromArgb(ForeColorRGB1, ForeColorRGB2, ForeColorRGB3);
            label1.ForeColor = Color.FromArgb(ForeColorRGB1, ForeColorRGB2, ForeColorRGB3); // table label
            //Background Image visibility
            BackgroundCream.Visible = imageBool1;
            BackgroundWhite.Visible = imageBool2;
        }
        private void darkModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColourSets(255,255,255 ,0, 0, 64, 0, 0, 64, false, false);//white, darkblue, darkblue, backgroundcream false, background white false
        }
        private void lightModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColourSets(0, 0, 0, 237, 237, 237, 194, 194, 194, false, true);//Black, lightgray, backgroundcream false, background white false
        }
        private void positnoteModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColourSets(0, 0, 0, 253, 236, 166, 253, 222, 149, true, false);//Black, lightgray, backgroundcream false, background white false
        }
    }
}
