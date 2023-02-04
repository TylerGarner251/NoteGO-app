using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
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
                #region settings Loader
                //checks presaved settings for background colours
                string settingsLoader = AppDomain.CurrentDomain.BaseDirectory + @"Settings\Settings.txt";
                string settingsInfo = File.ReadAllText(settingsLoader);
                switch(settingsInfo)
                {
                    case "darkMode":
                        darkmode();
                        break;
                    case "lightMode":
                        lightMode();
                        break;
                    case "positnoteMode":
                        postitNoteMode();
                        break;
                }
                #endregion
                #region Adding Files to List
                refresh();
                #endregion
            }
            catch
            {
                string subPath = "Settings";
                Directory.CreateDirectory(subPath);
                string settingsLoader = AppDomain.CurrentDomain.BaseDirectory + @"Settings\Settings.txt";
                File.Create(settingsLoader);
            }
        }
        #region Misc Calling
        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e) { }
        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e) { }
        private void TitleBox_TextChanged(object sender, EventArgs e) { }
        private void NotesBox_TextChanged(object sender, EventArgs e) { }
        private void NotesLabel_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void VisualButton_ButtonClick(object sender, EventArgs e) { }
        #endregion
        #region Button Controlls
        private void refresh()
        {
            DirectoryInfo root = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + @"\");

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
        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (table.Rows.Count == 0) // detects if a null value is in the rows before allowing export
            {
                MessageBox.Show("Error: There is no notes selected");
            }
            else
            {
                int index = Table.CurrentCell.RowIndex;
                String titleVar = table.Rows[index].ItemArray[0].ToString();
                saveFileDialog1.FileName = titleVar; //puts the filename as the title on notes
                saveFileDialog1.DefaultExt = "txt"; //puts the extension as .txt
                saveFileDialog1.AddExtension = true;
                saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 1;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK) //opens the save file explore
                {
                    string ExportPath = Path.GetFullPath(saveFileDialog1.FileName); //gets the path the user goes too
                    StreamWriter strm = File.CreateText(ExportPath); //creates a file in that path
                    strm.Close(); // close file
                    File.AppendAllText(ExportPath, NotesBox.Text); //adds notes to the file that was exported

                }
            }
        }
        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //importing File
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK) //opens the save file explore
            {
                try
                {
                    string ImportPath = Path.GetFullPath(openFileDialog1.FileName); //gets the path the user goes too
                    string fileName = openFileDialog1.SafeFileName;
                    string directoryPath = AppDomain.CurrentDomain.BaseDirectory + @"\" + fileName;
                    System.IO.File.Move(ImportPath, directoryPath);
                    Thread.Sleep(2000);
                    refresh();
                }
                catch
                {
                    MessageBox.Show("Error: Cannot Import, note has already been called the same name " +
                        "\n please rename your note then try again importing", "ERROR");
                }

            }
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int FontSize = ((int)FontControl.Value);
            TitleBox.Font = new Font("Microsoft Sans Serif", FontSize);
            NotesBox.Font = new Font("Microsoft Sans Serif", FontSize);
        }
        #endregion
        #region Colour Schemes
        private void ColourSets(int ForeColorRGB1, int ForeColorRGB2, int ForeColorRGB3, int BackColorRGB1, int BackColorRGB2, int BackColorRGB3, int WidgetBackColorRGB1, int WidgetBackColorRGB2, int WidgetBackColorRGB3)
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
        }
        private void Searchbar_TextChanged(object sender, EventArgs e)
        {//reads the search bar and checks the datagrid for character matches and brings up results.
            (Table.DataSource as DataTable).DefaultView.RowFilter = string.Format("Title LIKE '%{0}%'", Searchbar.Text);
        }
        public void darkmode()
        {
            ColourSets(255, 255, 255, 64, 64, 64, 64, 64, 64);//white, darkblue, darkblue.
            string settingsSave = AppDomain.CurrentDomain.BaseDirectory + @"Settings\Settings.txt";
            File.WriteAllText(settingsSave, "darkMode");
        }
        public void lightMode()
        {
            ColourSets(0, 0, 0, 237, 237, 237, 194, 194, 194);//Black, lightgray.
            string settingsSave = AppDomain.CurrentDomain.BaseDirectory + @"Settings\Settings.txt";
            File.WriteAllText(settingsSave, "lightMode");
        }
        public void postitNoteMode()
        {
            ColourSets(0, 0, 0, 253, 236, 166, 253, 222, 149);//Black, lightgray.
            string settingsSave = AppDomain.CurrentDomain.BaseDirectory + @"Settings\Settings.txt";
            File.WriteAllText(settingsSave, "positnoteMode");
        }

        #endregion

        private void SettingButton_Click(object sender, EventArgs e)
        {
           Settings newform = new Settings();
            newform.ShowDialog();
        }
    }
}
