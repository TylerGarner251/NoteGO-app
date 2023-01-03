using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Table.Columns["Title"].Width = 290;
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
                TitleBox.Text = table.Rows[index].ItemArray[0].ToString();
                NotesBox.Text = table.Rows[index].ItemArray[1].ToString();
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
    }
}
