
namespace NoteGO_app
{
    partial class NoteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteForm));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.NotesLabel = new System.Windows.Forms.Label();
            this.NotesBox = new System.Windows.Forms.RichTextBox();
            this.Table = new System.Windows.Forms.DataGridView();
            this.MenuBar = new System.Windows.Forms.StatusStrip();
            this.Newbutton = new System.Windows.Forms.ToolStripSplitButton();
            this.SaveButton = new System.Windows.Forms.ToolStripSplitButton();
            this.ReadButton = new System.Windows.Forms.ToolStripSplitButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripSplitButton();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.MenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(12, 45);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(45, 17);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Title:";
            // 
            // TitleBox
            // 
            this.TitleBox.BackColor = System.Drawing.Color.Moccasin;
            this.TitleBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleBox.Location = new System.Drawing.Point(63, 38);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(384, 29);
            this.TitleBox.TabIndex = 2;
            this.TitleBox.TextChanged += new System.EventHandler(this.TitleBox_TextChanged);
            // 
            // NotesLabel
            // 
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.NotesLabel.Location = new System.Drawing.Point(12, 87);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(55, 17);
            this.NotesLabel.TabIndex = 3;
            this.NotesLabel.Text = "Notes:";
            // 
            // NotesBox
            // 
            this.NotesBox.BackColor = System.Drawing.Color.Moccasin;
            this.NotesBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NotesBox.Location = new System.Drawing.Point(12, 107);
            this.NotesBox.Name = "NotesBox";
            this.NotesBox.Size = new System.Drawing.Size(435, 321);
            this.NotesBox.TabIndex = 4;
            this.NotesBox.Text = "";
            this.NotesBox.TextChanged += new System.EventHandler(this.NotesBox_TextChanged);
            // 
            // Table
            // 
            this.Table.AllowUserToAddRows = false;
            this.Table.AllowUserToDeleteRows = false;
            this.Table.AllowUserToResizeColumns = false;
            this.Table.AllowUserToResizeRows = false;
            this.Table.BackgroundColor = System.Drawing.Color.Moccasin;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.ColumnHeadersVisible = false;
            this.Table.GridColor = System.Drawing.Color.PapayaWhip;
            this.Table.Location = new System.Drawing.Point(453, 34);
            this.Table.MultiSelect = false;
            this.Table.Name = "Table";
            this.Table.ReadOnly = true;
            this.Table.RowHeadersVisible = false;
            this.Table.Size = new System.Drawing.Size(300, 394);
            this.Table.TabIndex = 5;
            this.Table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_CellContentClick);
            // 
            // MenuBar
            // 
            this.MenuBar.BackColor = System.Drawing.Color.NavajoWhite;
            this.MenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuBar.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Newbutton,
            this.SaveButton,
            this.ReadButton,
            this.DeleteButton});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(762, 31);
            this.MenuBar.Stretch = false;
            this.MenuBar.TabIndex = 7;
            this.MenuBar.Text = "statusStrip1";
            this.MenuBar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuBar_ItemClicked);
            // 
            // Newbutton
            // 
            this.Newbutton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Newbutton.Image = global::NoteGO_app.Properties.Resources.icons8_note_96;
            this.Newbutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Newbutton.Name = "Newbutton";
            this.Newbutton.Size = new System.Drawing.Size(41, 29);
            this.Newbutton.Text = "toolStripSplitButton1";
            this.Newbutton.ButtonClick += new System.EventHandler(this.Newbutton_ButtonClick);
            // 
            // SaveButton
            // 
            this.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveButton.Image = global::NoteGO_app.Properties.Resources.icons8_floppy_disk_68;
            this.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(41, 29);
            this.SaveButton.Text = "toolStripSplitButton2";
            this.SaveButton.ButtonClick += new System.EventHandler(this.SaveButton_ButtonClick);
            // 
            // ReadButton
            // 
            this.ReadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ReadButton.Image = global::NoteGO_app.Properties.Resources.icons8_binocular_64;
            this.ReadButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(41, 29);
            this.ReadButton.Text = "toolStripSplitButton1";
            this.ReadButton.ButtonClick += new System.EventHandler(this.ReadButton_ButtonClick);
            // 
            // DeleteButton
            // 
            this.DeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteButton.Image = global::NoteGO_app.Properties.Resources.icons8_bin_62;
            this.DeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(41, 29);
            this.DeleteButton.Text = "toolStripSplitButton1";
            this.DeleteButton.ButtonClick += new System.EventHandler(this.DeleteButton_ButtonClick);
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(762, 438);
            this.Controls.Add(this.MenuBar);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.NotesBox);
            this.Controls.Add(this.NotesLabel);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.TitleLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(778, 477);
            this.MinimumSize = new System.Drawing.Size(778, 477);
            this.Name = "NoteForm";
            this.Text = "Notes";
            this.Load += new System.EventHandler(this.NoteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.Label NotesLabel;
        private System.Windows.Forms.RichTextBox NotesBox;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.StatusStrip MenuBar;
        private System.Windows.Forms.ToolStripSplitButton Newbutton;
        private System.Windows.Forms.ToolStripSplitButton SaveButton;
        private System.Windows.Forms.ToolStripSplitButton DeleteButton;
        private System.Windows.Forms.ToolStripSplitButton ReadButton;
    }
}

